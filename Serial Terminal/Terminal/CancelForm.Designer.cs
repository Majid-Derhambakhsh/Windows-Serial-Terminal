namespace Terminal
{
    partial class CancelForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CancelForm));
            this.CancelForm_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CancelForm_DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.CancelForm_Timer = new System.Windows.Forms.Timer(this.components);
            this.CancelForm_BtnTimer = new System.Windows.Forms.Timer(this.components);
            this.CancelForm_Panel = new System.Windows.Forms.Panel();
            this.CancelForm_Lbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CancelForm_OkThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.CancelForm_PicBox = new System.Windows.Forms.PictureBox();
            this.CancelForm_PanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CancelForm_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CancelForm_PicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelForm_Elipse
            // 
            this.CancelForm_Elipse.ElipseRadius = 20;
            this.CancelForm_Elipse.TargetControl = this;
            // 
            // CancelForm_DragControl
            // 
            this.CancelForm_DragControl.Fixed = true;
            this.CancelForm_DragControl.Horizontal = true;
            this.CancelForm_DragControl.TargetControl = this;
            this.CancelForm_DragControl.Vertical = true;
            // 
            // CancelForm_Timer
            // 
            this.CancelForm_Timer.Enabled = true;
            this.CancelForm_Timer.Interval = 3000;
            this.CancelForm_Timer.Tick += new System.EventHandler(this.CancelForm_Timer_Tick);
            // 
            // CancelForm_BtnTimer
            // 
            this.CancelForm_BtnTimer.Enabled = true;
            this.CancelForm_BtnTimer.Interval = 500;
            this.CancelForm_BtnTimer.Tick += new System.EventHandler(this.CancelForm_BtnTimer_Tick);
            // 
            // CancelForm_Panel
            // 
            this.CancelForm_Panel.BackColor = System.Drawing.Color.White;
            this.CancelForm_Panel.Controls.Add(this.CancelForm_Lbl);
            this.CancelForm_Panel.Controls.Add(this.CancelForm_OkThinButton);
            this.CancelForm_Panel.Controls.Add(this.CancelForm_PicBox);
            this.CancelForm_Panel.Location = new System.Drawing.Point(1, 1);
            this.CancelForm_Panel.Name = "CancelForm_Panel";
            this.CancelForm_Panel.Size = new System.Drawing.Size(282, 197);
            this.CancelForm_Panel.TabIndex = 0;
            // 
            // CancelForm_Lbl
            // 
            this.CancelForm_Lbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelForm_Lbl.BackColor = System.Drawing.Color.Transparent;
            this.CancelForm_Lbl.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.CancelForm_Lbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CancelForm_Lbl.Location = new System.Drawing.Point(-1, 114);
            this.CancelForm_Lbl.Name = "CancelForm_Lbl";
            this.CancelForm_Lbl.Size = new System.Drawing.Size(285, 33);
            this.CancelForm_Lbl.TabIndex = 10;
            this.CancelForm_Lbl.Text = "Your Operation Canceled!";
            this.CancelForm_Lbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelForm_Lbl.Visible = false;
            // 
            // CancelForm_OkThinButton
            // 
            this.CancelForm_OkThinButton.ActiveBorderThickness = 1;
            this.CancelForm_OkThinButton.ActiveCornerRadius = 20;
            this.CancelForm_OkThinButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelForm_OkThinButton.ActiveForecolor = System.Drawing.Color.White;
            this.CancelForm_OkThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelForm_OkThinButton.BackColor = System.Drawing.Color.White;
            this.CancelForm_OkThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelForm_OkThinButton.BackgroundImage")));
            this.CancelForm_OkThinButton.ButtonText = "Ok";
            this.CancelForm_OkThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelForm_OkThinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelForm_OkThinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelForm_OkThinButton.IdleBorderThickness = 2;
            this.CancelForm_OkThinButton.IdleCornerRadius = 20;
            this.CancelForm_OkThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.CancelForm_OkThinButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelForm_OkThinButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelForm_OkThinButton.Location = new System.Drawing.Point(84, 149);
            this.CancelForm_OkThinButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelForm_OkThinButton.Name = "CancelForm_OkThinButton";
            this.CancelForm_OkThinButton.Size = new System.Drawing.Size(115, 45);
            this.CancelForm_OkThinButton.TabIndex = 9;
            this.CancelForm_OkThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelForm_OkThinButton.Visible = false;
            this.CancelForm_OkThinButton.Click += new System.EventHandler(this.CancelForm_OkThinButton_Click);
            // 
            // CancelForm_PicBox
            // 
            this.CancelForm_PicBox.Image = global::Terminal.Properties.Resources.Flower_2;
            this.CancelForm_PicBox.InitialImage = global::Terminal.Properties.Resources.Flower_2;
            this.CancelForm_PicBox.Location = new System.Drawing.Point(50, 2);
            this.CancelForm_PicBox.Name = "CancelForm_PicBox";
            this.CancelForm_PicBox.Size = new System.Drawing.Size(183, 117);
            this.CancelForm_PicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CancelForm_PicBox.TabIndex = 8;
            this.CancelForm_PicBox.TabStop = false;
            // 
            // CancelForm_PanelElipse
            // 
            this.CancelForm_PanelElipse.ElipseRadius = 20;
            this.CancelForm_PanelElipse.TargetControl = this.CancelForm_Panel;
            // 
            // CancelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(285, 200);
            this.Controls.Add(this.CancelForm_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CancelForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CancelForm";
            this.Load += new System.EventHandler(this.CancelForm_Load);
            this.CancelForm_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CancelForm_PicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse CancelForm_Elipse;
        private Bunifu.Framework.UI.BunifuDragControl CancelForm_DragControl;
        private System.Windows.Forms.Timer CancelForm_Timer;
        private System.Windows.Forms.Timer CancelForm_BtnTimer;
        private System.Windows.Forms.Panel CancelForm_Panel;
        private Bunifu.Framework.UI.BunifuCustomLabel CancelForm_Lbl;
        private Bunifu.Framework.UI.BunifuThinButton2 CancelForm_OkThinButton;
        private System.Windows.Forms.PictureBox CancelForm_PicBox;
        private Bunifu.Framework.UI.BunifuElipse CancelForm_PanelElipse;
    }
}