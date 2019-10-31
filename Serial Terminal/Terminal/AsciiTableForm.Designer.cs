namespace Terminal
{
    partial class AsciiTableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AsciiTableForm));
            this.AsciiTableForm_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AsciiTableForm_Panel = new System.Windows.Forms.Panel();
            this.AsciiTableForm_AsciiPicBox = new System.Windows.Forms.PictureBox();
            this.AsciiTableForm_OkThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.AsciiTableForm_PanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.AsciiTableForm_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AsciiTableForm_AsciiPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // AsciiTableForm_Elipse
            // 
            this.AsciiTableForm_Elipse.ElipseRadius = 5;
            this.AsciiTableForm_Elipse.TargetControl = this;
            // 
            // AsciiTableForm_Panel
            // 
            this.AsciiTableForm_Panel.BackColor = System.Drawing.Color.White;
            this.AsciiTableForm_Panel.Controls.Add(this.AsciiTableForm_AsciiPicBox);
            this.AsciiTableForm_Panel.Controls.Add(this.AsciiTableForm_OkThinButton);
            this.AsciiTableForm_Panel.Location = new System.Drawing.Point(1, 1);
            this.AsciiTableForm_Panel.Name = "AsciiTableForm_Panel";
            this.AsciiTableForm_Panel.Size = new System.Drawing.Size(1217, 620);
            this.AsciiTableForm_Panel.TabIndex = 1;
            // 
            // AsciiTableForm_AsciiPicBox
            // 
            this.AsciiTableForm_AsciiPicBox.Image = global::Terminal.Properties.Resources.ASCII_Conversion_Chart;
            this.AsciiTableForm_AsciiPicBox.InitialImage = global::Terminal.Properties.Resources.Help_2;
            this.AsciiTableForm_AsciiPicBox.Location = new System.Drawing.Point(11, 11);
            this.AsciiTableForm_AsciiPicBox.Name = "AsciiTableForm_AsciiPicBox";
            this.AsciiTableForm_AsciiPicBox.Size = new System.Drawing.Size(1196, 554);
            this.AsciiTableForm_AsciiPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AsciiTableForm_AsciiPicBox.TabIndex = 0;
            this.AsciiTableForm_AsciiPicBox.TabStop = false;
            // 
            // AsciiTableForm_OkThinButton
            // 
            this.AsciiTableForm_OkThinButton.ActiveBorderThickness = 1;
            this.AsciiTableForm_OkThinButton.ActiveCornerRadius = 20;
            this.AsciiTableForm_OkThinButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AsciiTableForm_OkThinButton.ActiveForecolor = System.Drawing.Color.White;
            this.AsciiTableForm_OkThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AsciiTableForm_OkThinButton.BackColor = System.Drawing.Color.White;
            this.AsciiTableForm_OkThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AsciiTableForm_OkThinButton.BackgroundImage")));
            this.AsciiTableForm_OkThinButton.ButtonText = "Ok";
            this.AsciiTableForm_OkThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AsciiTableForm_OkThinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AsciiTableForm_OkThinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AsciiTableForm_OkThinButton.IdleBorderThickness = 2;
            this.AsciiTableForm_OkThinButton.IdleCornerRadius = 20;
            this.AsciiTableForm_OkThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.AsciiTableForm_OkThinButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AsciiTableForm_OkThinButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(187)))), ((int)(((byte)(181)))));
            this.AsciiTableForm_OkThinButton.Location = new System.Drawing.Point(551, 563);
            this.AsciiTableForm_OkThinButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AsciiTableForm_OkThinButton.Name = "AsciiTableForm_OkThinButton";
            this.AsciiTableForm_OkThinButton.Size = new System.Drawing.Size(115, 45);
            this.AsciiTableForm_OkThinButton.TabIndex = 17;
            this.AsciiTableForm_OkThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AsciiTableForm_OkThinButton.Click += new System.EventHandler(this.AsciiTableForm_OkThinButton_Click);
            // 
            // AsciiTableForm_PanelElipse
            // 
            this.AsciiTableForm_PanelElipse.ElipseRadius = 5;
            this.AsciiTableForm_PanelElipse.TargetControl = this.AsciiTableForm_Panel;
            // 
            // AsciiTableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 623);
            this.Controls.Add(this.AsciiTableForm_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AsciiTableForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AsciiTableForm";
            this.AsciiTableForm_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AsciiTableForm_AsciiPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse AsciiTableForm_Elipse;
        private System.Windows.Forms.Panel AsciiTableForm_Panel;
        private System.Windows.Forms.PictureBox AsciiTableForm_AsciiPicBox;
        private Bunifu.Framework.UI.BunifuThinButton2 AsciiTableForm_OkThinButton;
        private Bunifu.Framework.UI.BunifuElipse AsciiTableForm_PanelElipse;
    }
}