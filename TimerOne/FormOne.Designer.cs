namespace TimerOne
{
   partial class FormOne
   {
      /// <summary>
      ///  Required designer variable.
      /// </summary>
      private System.ComponentModel.IContainer components = null;

      /// <summary>
      ///  Clean up any resources being used.
      /// </summary>
      /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
      protected override void Dispose(bool disposing)
      {
         if (disposing && (components != null))
         {
            components.Dispose();
         }
         base.Dispose(disposing);
      }

      #region Windows Form Designer generated code

      /// <summary>
      ///  Required method for Designer support - do not modify
      ///  the contents of this method with the code editor.
      /// </summary>
      private void InitializeComponent()
      {
         LabelStopwatch = new System.Windows.Forms.Label();
         ButtonReset = new System.Windows.Forms.Button();
         ButtonStop = new System.Windows.Forms.Button();
         ButtonStart = new System.Windows.Forms.Button();
         TextBoxSeconds = new System.Windows.Forms.TextBox();
         SuspendLayout();
         // 
         // LabelStopwatch
         // 
         LabelStopwatch.AutoSize = true;
         LabelStopwatch.Location = new System.Drawing.Point(12, 9);
         LabelStopwatch.Name = "LabelStopwatch";
         LabelStopwatch.Size = new System.Drawing.Size(99, 21);
         LabelStopwatch.TabIndex = 29;
         LabelStopwatch.Text = "Секундомер";
         // 
         // ButtonReset
         // 
         ButtonReset.Location = new System.Drawing.Point(149, 69);
         ButtonReset.Margin = new System.Windows.Forms.Padding(4);
         ButtonReset.Name = "ButtonReset";
         ButtonReset.Size = new System.Drawing.Size(65, 32);
         ButtonReset.TabIndex = 28;
         ButtonReset.Text = "Сброс";
         ButtonReset.UseVisualStyleBackColor = true;
         ButtonReset.Click += ButtonReset_Click;
         // 
         // ButtonStop
         // 
         ButtonStop.Location = new System.Drawing.Point(81, 69);
         ButtonStop.Margin = new System.Windows.Forms.Padding(4);
         ButtonStop.Name = "ButtonStop";
         ButtonStop.Size = new System.Drawing.Size(60, 32);
         ButtonStop.TabIndex = 27;
         ButtonStop.Text = "Стоп";
         ButtonStop.UseVisualStyleBackColor = true;
         ButtonStop.Click += ButtonStop_Click;
         // 
         // ButtonStart
         // 
         ButtonStart.Location = new System.Drawing.Point(13, 69);
         ButtonStart.Margin = new System.Windows.Forms.Padding(4);
         ButtonStart.Name = "ButtonStart";
         ButtonStart.Size = new System.Drawing.Size(60, 32);
         ButtonStart.TabIndex = 26;
         ButtonStart.Text = "Старт";
         ButtonStart.UseVisualStyleBackColor = true;
         ButtonStart.Click += ButtonStart_Click;
         // 
         // TextBoxSeconds
         // 
         TextBoxSeconds.Location = new System.Drawing.Point(12, 34);
         TextBoxSeconds.Margin = new System.Windows.Forms.Padding(4);
         TextBoxSeconds.Multiline = true;
         TextBoxSeconds.Name = "TextBoxSeconds";
         TextBoxSeconds.Size = new System.Drawing.Size(202, 27);
         TextBoxSeconds.TabIndex = 25;
         TextBoxSeconds.Text = "0";
         // 
         // FormOne
         // 
         AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
         ClientSize = new System.Drawing.Size(226, 113);
         Controls.Add(LabelStopwatch);
         Controls.Add(ButtonReset);
         Controls.Add(ButtonStop);
         Controls.Add(ButtonStart);
         Controls.Add(TextBoxSeconds);
         Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
         MaximizeBox = false;
         MinimizeBox = false;
         Name = "FormOne";
         StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         Text = "Таймер";
         FormClosing += FormOne_Closing;
         Load += this.FormOne_Load;
         ResumeLayout(false);
         PerformLayout();
      }

      #endregion

      private System.Windows.Forms.Label LabelStopwatch;
      private System.Windows.Forms.Button ButtonReset;
      private System.Windows.Forms.Button ButtonStop;
      private System.Windows.Forms.Button ButtonStart;
      private System.Windows.Forms.TextBox TextBoxSeconds;
   }
}