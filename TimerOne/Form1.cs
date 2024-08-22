using System;
using System.Windows.Forms;

// System.Threading.Timer

namespace TimerOne
{
   public partial class Form1 : Form
   {
      private System.Threading.Timer _t1;
      private TimeSpan _ts;

      public Form1()
      {
         InitializeComponent();
         _ts = new TimeSpan(0, 0, 0, 0, 0);
      }

      private void ButtonStart_Click(object sender, EventArgs e)
      {
         _t1 = new System.Threading.Timer(MetodSekundomer, null, 0, 10);
      }

      private void MetodSekundomer(object state)
      {
         Action action = delegate
         {
            _ts = _ts.Add(new TimeSpan(0, 0, 0, 0, 10));
            TextBoxSeconds.Text = _ts.ToString(@"hh\:mm\:ss\:ff");
         };
         Invoke(action);
      }

      private void ButtonStop_Click(object sender, EventArgs e)
      {
         //_t1.Change(0, 0);
         _t1.Change(System.Threading.Timeout.Infinite, 0);
      }

      private void ButtonReset_Click(object sender, EventArgs e)
      {
         _ts = new TimeSpan(0, 0, 0, 0, 0);
         TextBoxSeconds.Text = _ts.ToString(@"hh\:mm\:ss\:ff");
      }

      private void FormOne_Closing(object sender, FormClosingEventArgs e)
      {
         Application.Exit();
         _t1.Change(0, 0);
         _t1.Dispose();
      }
   }
}