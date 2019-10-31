namespace Terminal
{
    partial class ExitForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExitForm));
            this.ExitElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ExitForm_DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ExitForm_Panel = new System.Windows.Forms.Panel();
            this.QuestionLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.QuestionPicBox = new System.Windows.Forms.PictureBox();
            this.CancelThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ExitThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ExitForm_PanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.ExitForm_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ExitElipse
            // 
            this.ExitElipse.ElipseRadius = 15;
            this.ExitElipse.TargetControl = this;
            // 
            // ExitForm_DragControl
            // 
            this.ExitForm_DragControl.Fixed = true;
            this.ExitForm_DragControl.Horizontal = true;
            this.ExitForm_DragControl.TargetControl = this;
            this.ExitForm_DragControl.Vertical = true;
            // 
            // ExitForm_Panel
            // 
            this.ExitForm_Panel.BackColor = System.Drawing.Color.White;
            this.ExitForm_Panel.Controls.Add(this.QuestionLbl);
            this.ExitForm_Panel.Controls.Add(this.QuestionPicBox);
            this.ExitForm_Panel.Controls.Add(this.CancelThinButton);
            this.ExitForm_Panel.Controls.Add(this.ExitThinButton);
            this.ExitForm_Panel.Location = new System.Drawing.Point(2, 2);
            this.ExitForm_Panel.Name = "ExitForm_Panel";
            this.ExitForm_Panel.Size = new System.Drawing.Size(316, 216);
            this.ExitForm_Panel.TabIndex = 7;
            // 
            // QuestionLbl
            // 
            this.QuestionLbl.AutoSize = true;
            this.QuestionLbl.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.QuestionLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.QuestionLbl.Location = new System.Drawing.Point(83, 102);
            this.QuestionLbl.Name = "QuestionLbl";
            this.QuestionLbl.Size = new System.Drawing.Size(150, 32);
            this.QuestionLbl.TabIndex = 9;
            this.QuestionLbl.Text = "Are you sure";
            // 
            // QuestionPicBox
            // 
            this.QuestionPicBox.Image = global::Terminal.Properties.Resources.Question;
            this.QuestionPicBox.InitialImage = global::Terminal.Properties.Resources.Question;
            this.QuestionPicBox.Location = new System.Drawing.Point(23, 10);
            this.QuestionPicBox.Name = "QuestionPicBox";
            this.QuestionPicBox.Size = new System.Drawing.Size(270, 116);
            this.QuestionPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.QuestionPicBox.TabIndex = 10;
            this.QuestionPicBox.TabStop = false;
            // 
            // CancelThinButton
            // 
            this.CancelThinButton.ActiveBorderThickness = 1;
            this.CancelThinButton.ActiveCornerRadius = 20;
            this.CancelThinButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelThinButton.ActiveForecolor = System.Drawing.Color.White;
            this.CancelThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelThinButton.BackColor = System.Drawing.Color.White;
            this.CancelThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("CancelThinButton.BackgroundImage")));
            this.CancelThinButton.ButtonText = "Cancel";
            this.CancelThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelThinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CancelThinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelThinButton.IdleBorderThickness = 2;
            this.CancelThinButton.IdleCornerRadius = 20;
            this.CancelThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.CancelThinButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelThinButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.CancelThinButton.Location = new System.Drawing.Point(178, 162);
            this.CancelThinButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CancelThinButton.Name = "CancelThinButton";
            this.CancelThinButton.Size = new System.Drawing.Size(115, 45);
            this.CancelThinButton.TabIndex = 8;
            this.CancelThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CancelThinButton.Click += new System.EventHandler(this.CancelThinButton_Click);
            // 
            // ExitThinButton
            // 
            this.ExitThinButton.ActiveBorderThickness = 1;
            this.ExitThinButton.ActiveCornerRadius = 20;
            this.ExitThinButton.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.ExitThinButton.ActiveForecolor = System.Drawing.Color.White;
            this.ExitThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.ExitThinButton.BackColor = System.Drawing.Color.White;
            this.ExitThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ExitThinButton.BackgroundImage")));
            this.ExitThinButton.ButtonText = "Exit";
            this.ExitThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitThinButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitThinButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.ExitThinButton.IdleBorderThickness = 2;
            this.ExitThinButton.IdleCornerRadius = 20;
            this.ExitThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.ExitThinButton.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.ExitThinButton.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.ExitThinButton.Location = new System.Drawing.Point(23, 162);
            this.ExitThinButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ExitThinButton.Name = "ExitThinButton";
            this.ExitThinButton.Size = new System.Drawing.Size(115, 45);
            this.ExitThinButton.TabIndex = 7;
            this.ExitThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ExitThinButton.Click += new System.EventHandler(this.ExitThinButton_Click);
            // 
            // ExitForm_PanelElipse
            // 
            this.ExitForm_PanelElipse.ElipseRadius = 15;
            this.ExitForm_PanelElipse.TargetControl = this.ExitForm_Panel;
            // 
            // ExitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(206)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(320, 220);
            this.Controls.Add(this.ExitForm_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExitForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            this.ExitForm_Panel.ResumeLayout(false);
            this.ExitForm_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse ExitElipse;
        private Bunifu.Framework.UI.BunifuDragControl ExitForm_DragControl;
        private System.Windows.Forms.Panel ExitForm_Panel;
        private Bunifu.Framework.UI.BunifuCustomLabel QuestionLbl;
        private System.Windows.Forms.PictureBox QuestionPicBox;
        private Bunifu.Framework.UI.BunifuThinButton2 CancelThinButton;
        private Bunifu.Framework.UI.BunifuThinButton2 ExitThinButton;
        private Bunifu.Framework.UI.BunifuElipse ExitForm_PanelElipse;
    }
}