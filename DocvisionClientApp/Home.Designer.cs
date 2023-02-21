namespace DocvisionClientApp
{
    partial class Home
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.Collapse = new System.Windows.Forms.Button();
            this.Close = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.SendEmailButton = new System.Windows.Forms.Button();
            this.MainDialogBody = new System.Windows.Forms.Panel();
            this.MyToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.HeaderPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(76)))), ((int)(((byte)(96)))));
            this.HeaderPanel.Controls.Add(this.Collapse);
            this.HeaderPanel.Controls.Add(this.Close);
            this.HeaderPanel.Controls.Add(this.Logo);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(923, 38);
            this.HeaderPanel.TabIndex = 1;
            this.HeaderPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // Collapse
            // 
            this.Collapse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Collapse.BackgroundImage")));
            this.Collapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Collapse.FlatAppearance.BorderSize = 0;
            this.Collapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Collapse.Location = new System.Drawing.Point(853, 7);
            this.Collapse.Name = "Collapse";
            this.Collapse.Size = new System.Drawing.Size(26, 25);
            this.Collapse.TabIndex = 2;
            this.MyToolTip.SetToolTip(this.Collapse, "Свернуть окно");
            this.Collapse.UseVisualStyleBackColor = true;
            this.Collapse.Click += new System.EventHandler(this.Collapse_Click);
            // 
            // Close
            // 
            this.Close.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Close.BackgroundImage")));
            this.Close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Close.FlatAppearance.BorderSize = 0;
            this.Close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Close.Location = new System.Drawing.Point(885, 7);
            this.Close.Name = "Close";
            this.Close.Size = new System.Drawing.Size(26, 25);
            this.Close.TabIndex = 1;
            this.MyToolTip.SetToolTip(this.Close, "Закрыть программу");
            this.Close.UseVisualStyleBackColor = true;
            this.Close.Click += new System.EventHandler(this.Close_Click);
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(129, 38);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            this.Logo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NavigationPanel.Controls.Add(this.SendEmailButton);
            this.NavigationPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.NavigationPanel.Location = new System.Drawing.Point(0, 38);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(923, 50);
            this.NavigationPanel.TabIndex = 2;
            // 
            // SendEmailButton
            // 
            this.SendEmailButton.AccessibleName = "InboxButton";
            this.SendEmailButton.BackColor = System.Drawing.Color.White;
            this.SendEmailButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SendEmailButton.Font = new System.Drawing.Font("Ebrima", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SendEmailButton.Image = ((System.Drawing.Image)(resources.GetObject("SendEmailButton.Image")));
            this.SendEmailButton.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.SendEmailButton.Location = new System.Drawing.Point(3, 6);
            this.SendEmailButton.Name = "SendEmailButton";
            this.SendEmailButton.Size = new System.Drawing.Size(127, 38);
            this.SendEmailButton.TabIndex = 2;
            this.SendEmailButton.Text = "Send Email";
            this.SendEmailButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.SendEmailButton.UseVisualStyleBackColor = false;
            this.SendEmailButton.Click += new System.EventHandler(this.SenEmailButton_Click);
            // 
            // MainDialogBody
            // 
            this.MainDialogBody.AutoSize = true;
            this.MainDialogBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainDialogBody.Location = new System.Drawing.Point(0, 88);
            this.MainDialogBody.Name = "MainDialogBody";
            this.MainDialogBody.Size = new System.Drawing.Size(923, 350);
            this.MainDialogBody.TabIndex = 3;
            this.MainDialogBody.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint_1);
            // 
            // Home
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(923, 438);
            this.ControlBox = false;
            this.Controls.Add(this.MainDialogBody);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.HeaderPanel);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Docsvision client";
            this.Load += new System.EventHandler(this.Home_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form_MouseDown);
            this.HeaderPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
 
        private Panel HeaderPanel;
        private Panel NavigationPanel;
        private PictureBox Logo;
        private Button Close;
        private Button SendEmailButton;
        private Panel MainDialogBody;
        private Button Collapse;
        private ToolTip MyToolTip;
    }
}