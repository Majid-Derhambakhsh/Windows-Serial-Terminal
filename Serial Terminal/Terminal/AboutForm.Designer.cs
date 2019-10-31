namespace Terminal
{
    partial class AboutForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            this.AboutForm_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AboutForm_Panel = new System.Windows.Forms.Panel();
            this.AboutForm_Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.AboutForm_InfoLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AboutForm_DeveloperPicBox = new System.Windows.Forms.PictureBox();
            this.AboutForm_Lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AboutForm_TelegramIdLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AboutForm_EmailAddressLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AboutForm_InstagramIdLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AboutForm_EmailPicBox = new System.Windows.Forms.PictureBox();
            this.AboutForm_OkThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AboutForm_TelegramPicBox = new System.Windows.Forms.PictureBox();
            this.AboutForm_InstagramPicBox = new System.Windows.Forms.PictureBox();
            this.AboutForm_PanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AboutForm_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutForm_DeveloperPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutForm_EmailPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutForm_TelegramPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutForm_InstagramPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AboutForm_Elipse
            // 
            this.AboutForm_Elipse.ElipseRadius = 25;
            this.AboutForm_Elipse.TargetControl = this;
            // 
            // AboutForm_Panel
            // 
            this.AboutForm_Panel.BackColor = System.Drawing.Color.White;
            this.AboutForm_Panel.Controls.Add(this.AboutForm_Separator);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_InfoLbl);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_DeveloperPicBox);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_Lbl);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_TelegramIdLbl);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_EmailAddressLbl);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_InstagramIdLbl);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_EmailPicBox);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_OkThinButton);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_TelegramPicBox);
            this.AboutForm_Panel.Controls.Add(this.AboutForm_InstagramPicBox);
            this.AboutForm_Panel.Location = new System.Drawing.Point(2, 2);
            this.AboutForm_Panel.Name = "AboutForm_Panel";
            this.AboutForm_Panel.Size = new System.Drawing.Size(596, 356);
            this.AboutForm_Panel.TabIndex = 16;
            // 
            // AboutForm_Separator
            // 
            this.AboutForm_Separator.BackColor = System.Drawing.Color.Transparent;
            this.AboutForm_Separator.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AboutForm_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AboutForm_Separator.LineThickness = 1;
            this.AboutForm_Separator.Location = new System.Drawing.Point(271, 167);
            this.AboutForm_Separator.Name = "AboutForm_Separator";
            this.AboutForm_Separator.Size = new System.Drawing.Size(1, 85);
            this.AboutForm_Separator.TabIndex = 26;
            this.AboutForm_Separator.Transparency = 255;
            this.AboutForm_Separator.Vertical = true;
            // 
            // AboutForm_InfoLbl
            // 
            this.AboutForm_InfoLbl.AutoSize = true;
            this.AboutForm_InfoLbl.BackColor = System.Drawing.Color.Transparent;
            this.AboutForm_InfoLbl.Cursor = System.Windows.Forms.Cursors.Default;
            this.AboutForm_InfoLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.AboutForm_InfoLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutForm_InfoLbl.Location = new System.Drawing.Point(267, 75);
            this.AboutForm_InfoLbl.Name = "AboutForm_InfoLbl";
            this.AboutForm_InfoLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AboutForm_InfoLbl.Size = new System.Drawing.Size(282, 76);
            this.AboutForm_InfoLbl.TabIndex = 25;
            this.AboutForm_InfoLbl.Text = "Serial Terminal :\r\nThis software has been developed for use serial port.\r\n\r\nVersi" +
    "on 1.0.0.1\r\nAll right reserved.";
            this.AboutForm_InfoLbl.UseCompatibleTextRendering = true;
            // 
            // AboutForm_DeveloperPicBox
            // 
            this.AboutForm_DeveloperPicBox.BackColor = System.Drawing.Color.Transparent;
            this.AboutForm_DeveloperPicBox.Image = global::Terminal.Properties.Resources.Developer_2;
            this.AboutForm_DeveloperPicBox.InitialImage = global::Terminal.Properties.Resources.Developer_2;
            this.AboutForm_DeveloperPicBox.Location = new System.Drawing.Point(14, 80);
            this.AboutForm_DeveloperPicBox.Name = "AboutForm_DeveloperPicBox";
            this.AboutForm_DeveloperPicBox.Size = new System.Drawing.Size(240, 196);
            this.AboutForm_DeveloperPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AboutForm_DeveloperPicBox.TabIndex = 24;
            this.AboutForm_DeveloperPicBox.TabStop = false;
            // 
            // AboutForm_Lbl
            // 
            this.AboutForm_Lbl.AutoSize = true;
            this.AboutForm_Lbl.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Bold);
            this.AboutForm_Lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.AboutForm_Lbl.Location = new System.Drawing.Point(238, 13);
            this.AboutForm_Lbl.Name = "AboutForm_Lbl";
            this.AboutForm_Lbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AboutForm_Lbl.Size = new System.Drawing.Size(120, 46);
            this.AboutForm_Lbl.TabIndex = 23;
            this.AboutForm_Lbl.Text = "About";
            // 
            // AboutForm_TelegramIdLbl
            // 
            this.AboutForm_TelegramIdLbl.AutoSize = true;
            this.AboutForm_TelegramIdLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.AboutForm_TelegramIdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(135)))), ((int)(((byte)(203)))));
            this.AboutForm_TelegramIdLbl.Location = new System.Drawing.Point(322, 201);
            this.AboutForm_TelegramIdLbl.Name = "AboutForm_TelegramIdLbl";
            this.AboutForm_TelegramIdLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AboutForm_TelegramIdLbl.Size = new System.Drawing.Size(111, 12);
            this.AboutForm_TelegramIdLbl.TabIndex = 22;
            this.AboutForm_TelegramIdLbl.Text = "@MajidDerhambakhsh";
            this.AboutForm_TelegramIdLbl.Click += new System.EventHandler(this.AboutForm_TelegramIdLbl_Click);
            // 
            // AboutForm_EmailAddressLbl
            // 
            this.AboutForm_EmailAddressLbl.AutoSize = true;
            this.AboutForm_EmailAddressLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.AboutForm_EmailAddressLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(182)))), ((int)(((byte)(243)))));
            this.AboutForm_EmailAddressLbl.Location = new System.Drawing.Point(322, 234);
            this.AboutForm_EmailAddressLbl.Name = "AboutForm_EmailAddressLbl";
            this.AboutForm_EmailAddressLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AboutForm_EmailAddressLbl.Size = new System.Drawing.Size(118, 12);
            this.AboutForm_EmailAddressLbl.TabIndex = 21;
            this.AboutForm_EmailAddressLbl.Text = "Majid.do16@gmail.com";
            this.AboutForm_EmailAddressLbl.Click += new System.EventHandler(this.AboutForm_EmailAddressLbl_Click);
            // 
            // AboutForm_InstagramIdLbl
            // 
            this.AboutForm_InstagramIdLbl.AutoSize = true;
            this.AboutForm_InstagramIdLbl.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.AboutForm_InstagramIdLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(36)))), ((int)(((byte)(4)))));
            this.AboutForm_InstagramIdLbl.Location = new System.Drawing.Point(322, 171);
            this.AboutForm_InstagramIdLbl.Name = "AboutForm_InstagramIdLbl";
            this.AboutForm_InstagramIdLbl.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AboutForm_InstagramIdLbl.Size = new System.Drawing.Size(114, 12);
            this.AboutForm_InstagramIdLbl.TabIndex = 20;
            this.AboutForm_InstagramIdLbl.Text = "@Majid.Derhambakhsh";
            this.AboutForm_InstagramIdLbl.Click += new System.EventHandler(this.AboutForm_InstagramIdLbl_Click);
            // 
            // AboutForm_EmailPicBox
            // 
            this.AboutForm_EmailPicBox.BackColor = System.Drawing.Color.Transparent;
            this.AboutForm_EmailPicBox.Image = global::Terminal.Properties.Resources.Mail_2;
            this.AboutForm_EmailPicBox.InitialImage = global::Terminal.Properties.Resources.Mail_2;
            this.AboutForm_EmailPicBox.Location = new System.Drawing.Point(281, 225);
            this.AboutForm_EmailPicBox.Name = "AboutForm_EmailPicBox";
            this.AboutForm_EmailPicBox.Size = new System.Drawing.Size(30, 30);
            this.AboutForm_EmailPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AboutForm_EmailPicBox.TabIndex = 18;
            this.AboutForm_EmailPicBox.TabStop = false;
            this.AboutForm_EmailPicBox.Click += new System.EventHandler(this.AboutForm_EmailAddressLbl_Click);
            // 
            // AboutForm_OkThinButton
            // 
            this.AboutForm_OkThinButton.ActiveBorderThickness = 1;
            this.AboutForm_OkThinButton.ActiveCornerRadius = 20;
            this.AboutForm_OkThinButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AboutForm_OkThinButton.ActiveForecolor = System.Drawing.Color.White;
            this.AboutForm_OkThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AboutForm_OkThinButton.BackColor = System.Drawing.Color.White;
            this.AboutForm_OkThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AboutForm_OkThinButton.BackgroundImage")));
            this.AboutForm_OkThinButton.ButtonText = "Ok";
            this.AboutForm_OkThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AboutForm_OkThinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutForm_OkThinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AboutForm_OkThinButton.IdleBorderThickness = 2;
            this.AboutForm_OkThinButton.IdleCornerRadius = 20;
            this.AboutForm_OkThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.AboutForm_OkThinButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AboutForm_OkThinButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AboutForm_OkThinButton.Location = new System.Drawing.Point(241, 299);
            this.AboutForm_OkThinButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AboutForm_OkThinButton.Name = "AboutForm_OkThinButton";
            this.AboutForm_OkThinButton.Size = new System.Drawing.Size(115, 45);
            this.AboutForm_OkThinButton.TabIndex = 16;
            this.AboutForm_OkThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AboutForm_OkThinButton.Click += new System.EventHandler(this.AboutForm_OkThinButton_Click);
            // 
            // AboutForm_TelegramPicBox
            // 
            this.AboutForm_TelegramPicBox.BackColor = System.Drawing.Color.Transparent;
            this.AboutForm_TelegramPicBox.Image = global::Terminal.Properties.Resources.Telegram_1;
            this.AboutForm_TelegramPicBox.InitialImage = global::Terminal.Properties.Resources.Telegram_1;
            this.AboutForm_TelegramPicBox.Location = new System.Drawing.Point(284, 195);
            this.AboutForm_TelegramPicBox.Name = "AboutForm_TelegramPicBox";
            this.AboutForm_TelegramPicBox.Size = new System.Drawing.Size(25, 25);
            this.AboutForm_TelegramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AboutForm_TelegramPicBox.TabIndex = 17;
            this.AboutForm_TelegramPicBox.TabStop = false;
            this.AboutForm_TelegramPicBox.Click += new System.EventHandler(this.AboutForm_TelegramIdLbl_Click);
            // 
            // AboutForm_InstagramPicBox
            // 
            this.AboutForm_InstagramPicBox.BackColor = System.Drawing.Color.Transparent;
            this.AboutForm_InstagramPicBox.Image = global::Terminal.Properties.Resources.Instagram_6;
            this.AboutForm_InstagramPicBox.InitialImage = global::Terminal.Properties.Resources.Instagram_6;
            this.AboutForm_InstagramPicBox.Location = new System.Drawing.Point(284, 165);
            this.AboutForm_InstagramPicBox.Name = "AboutForm_InstagramPicBox";
            this.AboutForm_InstagramPicBox.Size = new System.Drawing.Size(25, 25);
            this.AboutForm_InstagramPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AboutForm_InstagramPicBox.TabIndex = 19;
            this.AboutForm_InstagramPicBox.TabStop = false;
            this.AboutForm_InstagramPicBox.Click += new System.EventHandler(this.AboutForm_InstagramIdLbl_Click);
            // 
            // AboutForm_PanelElipse
            // 
            this.AboutForm_PanelElipse.ElipseRadius = 25;
            this.AboutForm_PanelElipse.TargetControl = this.AboutForm_Panel;
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.AboutForm_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AboutForm";
            this.AboutForm_Panel.ResumeLayout(false);
            this.AboutForm_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AboutForm_DeveloperPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutForm_EmailPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutForm_TelegramPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AboutForm_InstagramPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse AboutForm_Elipse;
        private System.Windows.Forms.Panel AboutForm_Panel;
        private Bunifu.Framework.UI.BunifuSeparator AboutForm_Separator;
        private Bunifu.Framework.UI.BunifuCustomLabel AboutForm_InfoLbl;
        private System.Windows.Forms.PictureBox AboutForm_DeveloperPicBox;
        private Bunifu.Framework.UI.BunifuCustomLabel AboutForm_Lbl;
        private Bunifu.Framework.UI.BunifuCustomLabel AboutForm_TelegramIdLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel AboutForm_EmailAddressLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel AboutForm_InstagramIdLbl;
        private System.Windows.Forms.PictureBox AboutForm_EmailPicBox;
        private Bunifu.Framework.UI.BunifuThinButton2 AboutForm_OkThinButton;
        private System.Windows.Forms.PictureBox AboutForm_TelegramPicBox;
        private System.Windows.Forms.PictureBox AboutForm_InstagramPicBox;
        private Bunifu.Framework.UI.BunifuElipse AboutForm_PanelElipse;
    }
}