namespace DocsvisionClientApp.UserControls
{
    partial class UC_SendEmail
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.EmailSubject = new System.Windows.Forms.TextBox();
            this.EmailBody = new System.Windows.Forms.TextBox();
            this.EmailReceiverTextBox = new System.Windows.Forms.TextBox();
            this.SendEmail = new System.Windows.Forms.Button();
            this.EmailSender = new System.Windows.Forms.TextBox();
            this.BGWUpdateProfileList = new System.ComponentModel.BackgroundWorker();
            this.ErrorList = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmailSubject
            // 
            this.EmailSubject.Location = new System.Drawing.Point(50, 52);
            this.EmailSubject.Multiline = true;
            this.EmailSubject.Name = "EmailSubject";
            this.EmailSubject.PlaceholderText = "Тема письма";
            this.EmailSubject.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailSubject.Size = new System.Drawing.Size(376, 23);
            this.EmailSubject.TabIndex = 1;
            this.EmailSubject.Tag = "";
            this.EmailSubject.Validated += new System.EventHandler(this.BGWUpdateProfileList_DoWork);
            // 
            // EmailBody
            // 
            this.EmailBody.Location = new System.Drawing.Point(50, 110);
            this.EmailBody.Multiline = true;
            this.EmailBody.Name = "EmailBody";
            this.EmailBody.PlaceholderText = "Текст письма";
            this.EmailBody.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailBody.Size = new System.Drawing.Size(376, 198);
            this.EmailBody.TabIndex = 3;
            this.EmailBody.Tag = "";
            // 
            // EmailReceiverTextBox
            // 
            this.EmailReceiverTextBox.Location = new System.Drawing.Point(50, 81);
            this.EmailReceiverTextBox.Name = "EmailReceiverTextBox";
            this.EmailReceiverTextBox.PlaceholderText = "Получатель";
            this.EmailReceiverTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailReceiverTextBox.Size = new System.Drawing.Size(185, 23);
            this.EmailReceiverTextBox.TabIndex = 4;
            this.EmailReceiverTextBox.Tag = "";
            // 
            // SendEmail
            // 
            this.SendEmail.BackColor = System.Drawing.SystemColors.Highlight;
            this.SendEmail.Location = new System.Drawing.Point(50, 23);
            this.SendEmail.Name = "SendEmail";
            this.SendEmail.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.SendEmail.Size = new System.Drawing.Size(120, 23);
            this.SendEmail.TabIndex = 5;
            this.SendEmail.Text = "Отправить письмо";
            this.SendEmail.UseVisualStyleBackColor = false;
            this.SendEmail.Click += new System.EventHandler(this.SendEmail_Click);
            // 
            // EmailSender
            // 
            this.EmailSender.Location = new System.Drawing.Point(241, 81);
            this.EmailSender.Multiline = true;
            this.EmailSender.Name = "EmailSender";
            this.EmailSender.PlaceholderText = "Отправитель";
            this.EmailSender.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.EmailSender.Size = new System.Drawing.Size(185, 23);
            this.EmailSender.TabIndex = 6;
            this.EmailSender.Tag = "";
            // 
            // BGWUpdateProfileList
            // 
            this.BGWUpdateProfileList.DoWork += new System.ComponentModel.DoWorkEventHandler(this.BGWUpdateProfileList_DoWork);
            // 
            // ErrorList
            // 
            this.ErrorList.AcceptsReturn = true;
            this.ErrorList.Location = new System.Drawing.Point(448, 50);
            this.ErrorList.Multiline = true;
            this.ErrorList.Name = "ErrorList";
            this.ErrorList.PlaceholderText = "Лог отправки";
            this.ErrorList.ReadOnly = true;
            this.ErrorList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ErrorList.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.ErrorList.Size = new System.Drawing.Size(400, 258);
            this.ErrorList.TabIndex = 7;
            this.ErrorList.Tag = "";
            // 
            // UC_SendEmail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ErrorList);
            this.Controls.Add(this.EmailSender);
            this.Controls.Add(this.SendEmail);
            this.Controls.Add(this.EmailReceiverTextBox);
            this.Controls.Add(this.EmailBody);
            this.Controls.Add(this.EmailSubject);
            this.Name = "UC_SendEmail";
            this.Size = new System.Drawing.Size(899, 338);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox EmailSubject;
        private TextBox EmailBody;
        private TextBox EmailReceiverTextBox;
        private Button SendEmail;
        private TextBox EmailSender;
        private System.ComponentModel.BackgroundWorker BGWUpdateProfileList;
        private TextBox ErrorList;
    }
}
