namespace Terminal
{
    partial class HelpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpForm));
            this.HelpForm_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HelpForm_Panel = new System.Windows.Forms.Panel();
            this.HelpForm_PanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HelpForm_HelpPicBox = new System.Windows.Forms.PictureBox();
            this.HelpForm_OkThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.HelpForm_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HelpForm_HelpPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // HelpForm_Elipse
            // 
            this.HelpForm_Elipse.ElipseRadius = 5;
            this.HelpForm_Elipse.TargetControl = this;
            // 
            // HelpForm_Panel
            // 
            this.HelpForm_Panel.BackColor = System.Drawing.Color.White;
            this.HelpForm_Panel.Controls.Add(this.HelpForm_HelpPicBox);
            this.HelpForm_Panel.Controls.Add(this.HelpForm_OkThinButton);
            this.HelpForm_Panel.Location = new System.Drawing.Point(1, 1);
            this.HelpForm_Panel.Name = "HelpForm_Panel";
            this.HelpForm_Panel.Size = new System.Drawing.Size(1217, 620);
            this.HelpForm_Panel.TabIndex = 0;
            // 
            // HelpForm_PanelElipse
            // 
            this.HelpForm_PanelElipse.ElipseRadius = 5;
            this.HelpForm_PanelElipse.TargetControl = this.HelpForm_Panel;
            // 
            // HelpForm_HelpPicBox
            // 
            this.HelpForm_HelpPicBox.Image = global::Terminal.Properties.Resources.Help_2;
            this.HelpForm_HelpPicBox.InitialImage = global::Terminal.Properties.Resources.Help_2;
            this.HelpForm_HelpPicBox.Location = new System.Drawing.Point(11, 11);
            this.HelpForm_HelpPicBox.Name = "HelpForm_HelpPicBox";
            this.HelpForm_HelpPicBox.Size = new System.Drawing.Size(1196, 554);
            this.HelpForm_HelpPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.HelpForm_HelpPicBox.TabIndex = 0;
            this.HelpForm_HelpPicBox.TabStop = false;
            // 
            // HelpForm_OkThinButton
            // 
            this.HelpForm_OkThinButton.ActiveBorderThickness = 1;
            this.HelpForm_OkThinButton.ActiveCornerRadius = 20;
            this.HelpForm_OkThinButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.HelpForm_OkThinButton.ActiveForecolor = System.Drawing.Color.White;
            this.HelpForm_OkThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.HelpForm_OkThinButton.BackColor = System.Drawing.Color.White;
            this.HelpForm_OkThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HelpForm_OkThinButton.BackgroundImage")));
            this.HelpForm_OkThinButton.ButtonText = "Ok";
            this.HelpForm_OkThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HelpForm_OkThinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpForm_OkThinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.HelpForm_OkThinButton.IdleBorderThickness = 2;
            this.HelpForm_OkThinButton.IdleCornerRadius = 20;
            this.HelpForm_OkThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.HelpForm_OkThinButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.HelpForm_OkThinButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.HelpForm_OkThinButton.Location = new System.Drawing.Point(551, 563);
            this.HelpForm_OkThinButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.HelpForm_OkThinButton.Name = "HelpForm_OkThinButton";
            this.HelpForm_OkThinButton.Size = new System.Drawing.Size(115, 45);
            this.HelpForm_OkThinButton.TabIndex = 17;
            this.HelpForm_OkThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HelpForm_OkThinButton.Click += new System.EventHandler(this.HelpForm_OkThinButton_Click);
            // 
            // HelpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(1220, 623);
            this.Controls.Add(this.HelpForm_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HelpForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HelpForm";
            this.HelpForm_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.HelpForm_HelpPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse HelpForm_Elipse;
        private System.Windows.Forms.Panel HelpForm_Panel;
        private Bunifu.Framework.UI.BunifuElipse HelpForm_PanelElipse;
        private System.Windows.Forms.PictureBox HelpForm_HelpPicBox;
        private Bunifu.Framework.UI.BunifuThinButton2 HelpForm_OkThinButton;
    }
}