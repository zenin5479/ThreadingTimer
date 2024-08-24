using System.Threading;
using System;
using System.Windows.Forms;

// System.Threading.Timer

namespace TimerThree
{
   public partial class Form1 : Form
   {
      private System.Threading.Timer _stateTimer;

      public Form1()
      {
         InitializeComponent();
      }

      private void Form1_Load(object sender, EventArgs e)
      {

      }

      private void ButtonStart_Click(object sender, EventArgs e)
      {
         // Создаем AutoResetEvent чтобы сигнализировать о достижении порога тайм-аута в обратном вызове по таймеру
         // AutoResetEvent событие синхронизации потоков, которое при сигнале освобождает один поток ожидания и автоматически сбрасывает его
         AutoResetEvent autoEvent = new AutoResetEvent(false);
         StatusChecker statusChecker = new StatusChecker(7);

         // Создаем таймер, который запускает проверку состояния через 0,1 секунды, и каждые 0,5 секунды после этого
         TextBoxSeconds.AppendText(DateTime.Now.ToString("h:mm:ss.fff") + " Создание таймера" + Environment.NewLine);
         _stateTimer = new System.Threading.Timer(statusChecker.CheckStatus, autoEvent, 100, 500);

         // При появлении сигнала автоматического события изменяем период на каждые 0,3 секунды.
         autoEvent.WaitOne();
         _stateTimer.Change(0, 300);
         TextBoxSeconds.AppendText("Изменение периода на 0,3 секунды" + Environment.NewLine);

         // Когда автоматическое событие подаст сигнал во второй раз, отключаем таймер
         autoEvent.WaitOne();
         _stateTimer.Dispose();
         TextBoxSeconds.AppendText("Освобождение ресурсов" + Environment.NewLine);
      }

      private void ButtonReset_Click(object sender, EventArgs e)
      {
         TextBoxSeconds.Clear();
      }
   }

   internal class StatusChecker
   {
      private int _invokeCount;
      private readonly int _maxCount;

      public StatusChecker(int count)
      {
         _invokeCount = 0;
         _maxCount = count;
      }

      // Метод вызывается делегатом таймера
      public void CheckStatus(object stateInfo)
      {
         AutoResetEvent autoEvent = (AutoResetEvent)stateInfo;
         Form1.TextBoxSeconds.AppendText(string.Format("{0:h:mm:ss.fff} Проверка статуса {1}", DateTime.Now,
            (++_invokeCount).ToString()) + Environment.NewLine);

         //FormOne.TextBoxSeconds.AppendText(DateTime.Now.ToString("h:mm:ss.fff") + " Проверка статуса "
         //   + (++_invokeCount) + Environment.NewLine);

         if (_invokeCount == _maxCount)
         {
            // Сбрасываем счетчик и подаем сигнал ожидающему потоку
            _invokeCount = 0;
            autoEvent.Set();
         }
      }
   }
}