using System;
using System.Windows.Forms;

// System.Threading.Timer

namespace TimerTwo
{
   public partial class FormOne : Form
   {
      private System.Threading.Timer _t1;

      public FormOne()
      {
         InitializeComponent();
      }

      private void FormOne_Load(object sender, EventArgs e)
      {

      }

      private void ButtonStart_Click(object sender, EventArgs e)
      {
         // Вариант 1
         // Создаем таймер
         _t1 = new System.Threading.Timer(MetodSekundomer, null, 0, 1000);

         // Вариант 2
         //int num = 0;
         // Создаем таймер
         //_t1 = new System.Threading.Timer(MetodSekundomer, num, 0, 1000);

         // Вариант 3
         //int num = 0;
         // Устанавливаем метод обратного вызова
         //TimerCallback tm = MetodSekundomer;
         // Создаем таймер
         //_t1 = new System.Threading.Timer(tm, num, 0, 1000);
      }

      private void MetodSekundomer(object state)
      {
         // Вариант 1
         Action action = delegate
         {
            int x = 0;
            for (int i = 1; i < 9; i++, x++)
            {
               TextBoxSeconds.AppendText($@"{x * i}" + Environment.NewLine);
            }
         };
         Invoke(action);

         // Вариант 1.1
         //Invoke((Action)Action);
         //return;
         //void Action()
         //{
         //   int x = 0;
         //   for (int i = 1; i < 9; i++, x++)
         //   {
         //      TextBoxSeconds.AppendText($@"{x * i}" + Environment.NewLine);
         //   }
         //}

         // Вариант 2
         //int x = (int)state;
         //for (int i = 1; i < 9; i++, x++)
         //{
         //   TextBoxSeconds.AppendText($@"{x * i}" + Environment.NewLine);
         //}

         // Вариант 3
         //int x = (int)state;
         //for (int i = 1; i < 9; i++, x++)
         //{
         //   TextBoxSeconds.AppendText($@"{x * i}" + Environment.NewLine);
         //}
      }

      private void ButtonStop_Click(object sender, EventArgs e)
      {
         //_t1.Change(0, 0);
         _t1.Change(System.Threading.Timeout.Infinite, 0);
      }

      private void ButtonReset_Click(object sender, EventArgs e)
      {
         TextBoxSeconds.Clear();
      }

      private void FormOne_Closing(object sender, FormClosingEventArgs e)
      {
         Application.Exit();
         _t1.Change(0, 0);
         _t1.Dispose();
      }
   }
}