namespace Terminal
{
    partial class CustomForm
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
            this.CustomForm_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CustomForm_DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.CustomForm_Timer = new System.Windows.Forms.Timer(this.components);
            this.CustomForm_Panel = new System.Windows.Forms.Panel();
            this.CustomLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.CustomPicBox = new System.Windows.Forms.PictureBox();
            this.CustomForm_PanelElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.CustomForm_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CustomPicBox)).BeginInit();
            this.SuspendLayout();
            // 
            // CustomForm_Elipse
            // 
            this.CustomForm_Elipse.ElipseRadius = 20;
            this.CustomForm_Elipse.TargetControl = this;
            // 
            // CustomForm_DragControl
            // 
            this.CustomForm_DragControl.Fixed = true;
            this.CustomForm_DragControl.Horizontal = true;
            this.CustomForm_DragControl.TargetControl = this;
            this.CustomForm_DragControl.Vertical = true;
            // 
            // CustomForm_Timer
            // 
            this.CustomForm_Timer.Enabled = true;
            this.CustomForm_Timer.Interval = 10000;
            this.CustomForm_Timer.Tick += new System.EventHandler(this.CustomForm_Timer_Tick);
            // 
            // CustomForm_Panel
            // 
            this.CustomForm_Panel.BackColor = System.Drawing.Color.White;
            this.CustomForm_Panel.Controls.Add(this.CustomLbl);
            this.CustomForm_Panel.Controls.Add(this.CustomPicBox);
            this.CustomForm_Panel.Location = new System.Drawing.Point(2, 2);
            this.CustomForm_Panel.Name = "CustomForm_Panel";
            this.CustomForm_Panel.Size = new System.Drawing.Size(496, 296);
            this.CustomForm_Panel.TabIndex = 0;
            // 
            // CustomLbl
            // 
            this.CustomLbl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomLbl.BackColor = System.Drawing.Color.Transparent;
            this.CustomLbl.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.CustomLbl.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.CustomLbl.Location = new System.Drawing.Point(0, 231);
            this.CustomLbl.Name = "CustomLbl";
            this.CustomLbl.Size = new System.Drawing.Size(496, 58);
            this.CustomLbl.TabIndex = 10;
            this.CustomLbl.Text = "Loading";
            this.CustomLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CustomPicBox
            // 
            this.CustomPicBox.BackColor = System.Drawing.Color.Transparent;
            this.CustomPicBox.Image = global::Terminal.Properties.Resources.Select;
            this.CustomPicBox.Location = new System.Drawing.Point(102, 8);
            this.CustomPicBox.Name = "CustomPicBox";
            this.CustomPicBox.Size = new System.Drawing.Size(273, 204);
            this.CustomPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CustomPicBox.TabIndex = 9;
            this.CustomPicBox.TabStop = false;
            this.CustomPicBox.Click += new System.EventHandler(this.LoadPicBox_Click);
            // 
            // CustomForm_PanelElipse
            // 
            this.CustomForm_PanelElipse.ElipseRadius = 20;
            this.CustomForm_PanelElipse.TargetControl = this.CustomForm_Panel;
            // 
            // CustomForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.CustomForm_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CustomForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomForm";
            this.CustomForm_Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CustomPicBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse CustomForm_Elipse;
        private Bunifu.Framework.UI.BunifuDragControl CustomForm_DragControl;
        private System.Windows.Forms.Timer CustomForm_Timer;
        private System.Windows.Forms.Panel CustomForm_Panel;
        private Bunifu.Framework.UI.BunifuCustomLabel CustomLbl;
        private System.Windows.Forms.PictureBox CustomPicBox;
        private Bunifu.Framework.UI.BunifuElipse CustomForm_PanelElipse;
    }
}