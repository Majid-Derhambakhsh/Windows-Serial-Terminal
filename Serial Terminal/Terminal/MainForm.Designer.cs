namespace Terminal
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainForm_Elipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainForm_DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ComPort_ScanBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SerialPort_Connection = new System.IO.Ports.SerialPort(this.components);
            this.ComPort_ConnectBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataBit_Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.DataBit_5RadioButton = new System.Windows.Forms.RadioButton();
            this.DataBit_6RadioButton = new System.Windows.Forms.RadioButton();
            this.DataBit_7RadioButton = new System.Windows.Forms.RadioButton();
            this.DataBit_8RadioButton = new System.Windows.Forms.RadioButton();
            this.DataBit_GroupBox = new System.Windows.Forms.GroupBox();
            this.Parity_Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.Parity_SpaceRadioButton = new System.Windows.Forms.RadioButton();
            this.Parity_MarkRadioButton = new System.Windows.Forms.RadioButton();
            this.Parity_EvenRadioButton = new System.Windows.Forms.RadioButton();
            this.Parity_OddRadioButton = new System.Windows.Forms.RadioButton();
            this.Parity_NonRadioButton = new System.Windows.Forms.RadioButton();
            this.Parity_GroupBox = new System.Windows.Forms.GroupBox();
            this.StopBit_Separator = new Bunifu.Framework.UI.BunifuSeparator();
            this.StopBit_1RadioButton = new System.Windows.Forms.RadioButton();
            this.StopBit_2RadioButton = new System.Windows.Forms.RadioButton();
            this.StopBit_GroupBox = new System.Windows.Forms.GroupBox();
            this.DataReceived_ClearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataReceived_ExportBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataSend_ExportBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.BaudRate_GroupBox = new System.Windows.Forms.GroupBox();
            this.BaudRate_57600RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_115200RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_128000RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_256000RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_14400RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_19200RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_28800RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_38400RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_56000RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_600RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_1200RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_2400RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_4800RadioButton = new System.Windows.Forms.RadioButton();
            this.BaudRate_9600RadioButton = new System.Windows.Forms.RadioButton();
            this.bunifuSeparator1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.ComPort_ComboBox = new System.Windows.Forms.ComboBox();
            this.ComPort_GroupBox = new System.Windows.Forms.GroupBox();
            this.DataSend_ClearBtn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.SerialPort_SendDataListBox = new System.Windows.Forms.ListBox();
            this.SerialPort_SendDataTxtBox = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.SerialPort_ReceivedDataTxtBox = new System.Windows.Forms.RichTextBox();
            this.SendWithCRCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SendWithLFCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SendWithCRLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SendWithLFLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Handshake_RTS_CTS_XOnXOffRadioButton = new System.Windows.Forms.RadioButton();
            this.Handshake_RTS_CTSRadioButton = new System.Windows.Forms.RadioButton();
            this.Handshake_XOnXOffRadioButton = new System.Windows.Forms.RadioButton();
            this.Handshake_NonRadioButton = new System.Windows.Forms.RadioButton();
            this.bunifuSeparator2 = new Bunifu.Framework.UI.BunifuSeparator();
            this.SerialPort_DtrCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SerialPort_RtsCheckBox = new Bunifu.Framework.UI.BunifuCheckbox();
            this.SerialPort_RtsLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.SerialPort_DtrLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.MinimizePicBox = new System.Windows.Forms.PictureBox();
            this.ClosePicBox = new System.Windows.Forms.PictureBox();
            this.DataSend_SendBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ControlPanel = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.Panel_AsciiThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.VersionLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Panel_AboutThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Panel_Logo = new System.Windows.Forms.PictureBox();
            this.Panel_HelpThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Panel_ExitThinButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DataSend_SendFileBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.IncrementFontSizeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.DecrementFontSizeBtn = new Bunifu.Framework.UI.BunifuThinButton2();
            this.FontSizeLbl = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.DataBit_GroupBox.SuspendLayout();
            this.Parity_GroupBox.SuspendLayout();
            this.StopBit_GroupBox.SuspendLayout();
            this.BaudRate_GroupBox.SuspendLayout();
            this.ComPort_GroupBox.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).BeginInit();
            this.ControlPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // MainForm_Elipse
            // 
            this.MainForm_Elipse.ElipseRadius = 15;
            this.MainForm_Elipse.TargetControl = this;
            // 
            // MainForm_DragControl
            // 
            this.MainForm_DragControl.Fixed = true;
            this.MainForm_DragControl.Horizontal = true;
            this.MainForm_DragControl.TargetControl = this;
            this.MainForm_DragControl.Vertical = true;
            // 
            // ComPort_ScanBtn
            // 
            this.ComPort_ScanBtn.Active = false;
            this.ComPort_ScanBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.ComPort_ScanBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.ComPort_ScanBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComPort_ScanBtn.BorderRadius = 5;
            this.ComPort_ScanBtn.ButtonText = "Scan";
            this.ComPort_ScanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComPort_ScanBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ComPort_ScanBtn.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.ComPort_ScanBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ComPort_ScanBtn.Iconimage = null;
            this.ComPort_ScanBtn.Iconimage_right = null;
            this.ComPort_ScanBtn.Iconimage_right_Selected = null;
            this.ComPort_ScanBtn.Iconimage_Selected = null;
            this.ComPort_ScanBtn.IconMarginLeft = 0;
            this.ComPort_ScanBtn.IconMarginRight = 0;
            this.ComPort_ScanBtn.IconRightVisible = true;
            this.ComPort_ScanBtn.IconRightZoom = 0D;
            this.ComPort_ScanBtn.IconVisible = true;
            this.ComPort_ScanBtn.IconZoom = 90D;
            this.ComPort_ScanBtn.IsTab = false;
            this.ComPort_ScanBtn.Location = new System.Drawing.Point(5, 61);
            this.ComPort_ScanBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComPort_ScanBtn.Name = "ComPort_ScanBtn";
            this.ComPort_ScanBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.ComPort_ScanBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ComPort_ScanBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ComPort_ScanBtn.selected = false;
            this.ComPort_ScanBtn.Size = new System.Drawing.Size(146, 21);
            this.ComPort_ScanBtn.TabIndex = 1;
            this.ComPort_ScanBtn.Text = "Scan";
            this.ComPort_ScanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComPort_ScanBtn.Textcolor = System.Drawing.Color.White;
            this.ComPort_ScanBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPort_ScanBtn.Click += new System.EventHandler(this.ComPort_ScanBtn_Click);
            // 
            // SerialPort_Connection
            // 
            this.SerialPort_Connection.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.DataReceivedHandler);
            // 
            // ComPort_ConnectBtn
            // 
            this.ComPort_ConnectBtn.Active = false;
            this.ComPort_ConnectBtn.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.ComPort_ConnectBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.ComPort_ConnectBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ComPort_ConnectBtn.BorderRadius = 5;
            this.ComPort_ConnectBtn.ButtonText = "Connect";
            this.ComPort_ConnectBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ComPort_ConnectBtn.DisabledColor = System.Drawing.Color.Gray;
            this.ComPort_ConnectBtn.Font = new System.Drawing.Font("Segoe UI", 6F);
            this.ComPort_ConnectBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.ComPort_ConnectBtn.Iconimage = null;
            this.ComPort_ConnectBtn.Iconimage_right = null;
            this.ComPort_ConnectBtn.Iconimage_right_Selected = null;
            this.ComPort_ConnectBtn.Iconimage_Selected = null;
            this.ComPort_ConnectBtn.IconMarginLeft = 0;
            this.ComPort_ConnectBtn.IconMarginRight = 0;
            this.ComPort_ConnectBtn.IconRightVisible = true;
            this.ComPort_ConnectBtn.IconRightZoom = 0D;
            this.ComPort_ConnectBtn.IconVisible = true;
            this.ComPort_ConnectBtn.IconZoom = 90D;
            this.ComPort_ConnectBtn.IsTab = false;
            this.ComPort_ConnectBtn.Location = new System.Drawing.Point(5, 98);
            this.ComPort_ConnectBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.ComPort_ConnectBtn.Name = "ComPort_ConnectBtn";
            this.ComPort_ConnectBtn.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.ComPort_ConnectBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.ComPort_ConnectBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.ComPort_ConnectBtn.selected = false;
            this.ComPort_ConnectBtn.Size = new System.Drawing.Size(146, 21);
            this.ComPort_ConnectBtn.TabIndex = 2;
            this.ComPort_ConnectBtn.Text = "Connect";
            this.ComPort_ConnectBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ComPort_ConnectBtn.Textcolor = System.Drawing.Color.White;
            this.ComPort_ConnectBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPort_ConnectBtn.Click += new System.EventHandler(this.ComPort_ConnectBtn_Click);
            // 
            // DataBit_Separator
            // 
            this.DataBit_Separator.BackColor = System.Drawing.Color.Transparent;
            this.DataBit_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.DataBit_Separator.LineThickness = 1;
            this.DataBit_Separator.Location = new System.Drawing.Point(11, 22);
            this.DataBit_Separator.Name = "DataBit_Separator";
            this.DataBit_Separator.Size = new System.Drawing.Size(10, 94);
            this.DataBit_Separator.TabIndex = 13;
            this.DataBit_Separator.Transparency = 255;
            this.DataBit_Separator.Vertical = true;
            // 
            // DataBit_5RadioButton
            // 
            this.DataBit_5RadioButton.AutoSize = true;
            this.DataBit_5RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.DataBit_5RadioButton.Location = new System.Drawing.Point(11, 22);
            this.DataBit_5RadioButton.Name = "DataBit_5RadioButton";
            this.DataBit_5RadioButton.Size = new System.Drawing.Size(32, 19);
            this.DataBit_5RadioButton.TabIndex = 0;
            this.DataBit_5RadioButton.Text = "5";
            this.DataBit_5RadioButton.UseVisualStyleBackColor = true;
            this.DataBit_5RadioButton.CheckedChanged += new System.EventHandler(this.DataBit_Changed);
            // 
            // DataBit_6RadioButton
            // 
            this.DataBit_6RadioButton.AutoSize = true;
            this.DataBit_6RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.DataBit_6RadioButton.Location = new System.Drawing.Point(11, 47);
            this.DataBit_6RadioButton.Name = "DataBit_6RadioButton";
            this.DataBit_6RadioButton.Size = new System.Drawing.Size(32, 19);
            this.DataBit_6RadioButton.TabIndex = 1;
            this.DataBit_6RadioButton.Text = "6";
            this.DataBit_6RadioButton.UseVisualStyleBackColor = true;
            this.DataBit_6RadioButton.CheckedChanged += new System.EventHandler(this.DataBit_Changed);
            // 
            // DataBit_7RadioButton
            // 
            this.DataBit_7RadioButton.AutoSize = true;
            this.DataBit_7RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.DataBit_7RadioButton.Location = new System.Drawing.Point(11, 72);
            this.DataBit_7RadioButton.Name = "DataBit_7RadioButton";
            this.DataBit_7RadioButton.Size = new System.Drawing.Size(32, 19);
            this.DataBit_7RadioButton.TabIndex = 2;
            this.DataBit_7RadioButton.Text = "7";
            this.DataBit_7RadioButton.UseVisualStyleBackColor = true;
            this.DataBit_7RadioButton.CheckedChanged += new System.EventHandler(this.DataBit_Changed);
            // 
            // DataBit_8RadioButton
            // 
            this.DataBit_8RadioButton.AutoSize = true;
            this.DataBit_8RadioButton.Checked = true;
            this.DataBit_8RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.DataBit_8RadioButton.Location = new System.Drawing.Point(11, 97);
            this.DataBit_8RadioButton.Name = "DataBit_8RadioButton";
            this.DataBit_8RadioButton.Size = new System.Drawing.Size(32, 19);
            this.DataBit_8RadioButton.TabIndex = 3;
            this.DataBit_8RadioButton.TabStop = true;
            this.DataBit_8RadioButton.Text = "8";
            this.DataBit_8RadioButton.UseVisualStyleBackColor = true;
            this.DataBit_8RadioButton.CheckedChanged += new System.EventHandler(this.DataBit_Changed);
            // 
            // DataBit_GroupBox
            // 
            this.DataBit_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.DataBit_GroupBox.Controls.Add(this.DataBit_8RadioButton);
            this.DataBit_GroupBox.Controls.Add(this.DataBit_7RadioButton);
            this.DataBit_GroupBox.Controls.Add(this.DataBit_6RadioButton);
            this.DataBit_GroupBox.Controls.Add(this.DataBit_5RadioButton);
            this.DataBit_GroupBox.Controls.Add(this.DataBit_Separator);
            this.DataBit_GroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBit_GroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.DataBit_GroupBox.Location = new System.Drawing.Point(554, 23);
            this.DataBit_GroupBox.Name = "DataBit_GroupBox";
            this.DataBit_GroupBox.Size = new System.Drawing.Size(74, 125);
            this.DataBit_GroupBox.TabIndex = 3;
            this.DataBit_GroupBox.TabStop = false;
            this.DataBit_GroupBox.Text = "Data Bits";
            // 
            // Parity_Separator
            // 
            this.Parity_Separator.BackColor = System.Drawing.Color.Transparent;
            this.Parity_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Parity_Separator.LineThickness = 1;
            this.Parity_Separator.Location = new System.Drawing.Point(11, 22);
            this.Parity_Separator.Name = "Parity_Separator";
            this.Parity_Separator.Size = new System.Drawing.Size(10, 94);
            this.Parity_Separator.TabIndex = 13;
            this.Parity_Separator.Transparency = 255;
            this.Parity_Separator.Vertical = true;
            // 
            // Parity_SpaceRadioButton
            // 
            this.Parity_SpaceRadioButton.AutoSize = true;
            this.Parity_SpaceRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.Parity_SpaceRadioButton.Location = new System.Drawing.Point(11, 98);
            this.Parity_SpaceRadioButton.Name = "Parity_SpaceRadioButton";
            this.Parity_SpaceRadioButton.Size = new System.Drawing.Size(58, 19);
            this.Parity_SpaceRadioButton.TabIndex = 4;
            this.Parity_SpaceRadioButton.Text = "Space";
            this.Parity_SpaceRadioButton.UseVisualStyleBackColor = true;
            this.Parity_SpaceRadioButton.CheckedChanged += new System.EventHandler(this.Parity_Changed);
            // 
            // Parity_MarkRadioButton
            // 
            this.Parity_MarkRadioButton.AutoSize = true;
            this.Parity_MarkRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.Parity_MarkRadioButton.Location = new System.Drawing.Point(11, 79);
            this.Parity_MarkRadioButton.Name = "Parity_MarkRadioButton";
            this.Parity_MarkRadioButton.Size = new System.Drawing.Size(54, 19);
            this.Parity_MarkRadioButton.TabIndex = 3;
            this.Parity_MarkRadioButton.Text = "Mark";
            this.Parity_MarkRadioButton.UseVisualStyleBackColor = true;
            this.Parity_MarkRadioButton.CheckedChanged += new System.EventHandler(this.Parity_Changed);
            // 
            // Parity_EvenRadioButton
            // 
            this.Parity_EvenRadioButton.AutoSize = true;
            this.Parity_EvenRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.Parity_EvenRadioButton.Location = new System.Drawing.Point(11, 60);
            this.Parity_EvenRadioButton.Name = "Parity_EvenRadioButton";
            this.Parity_EvenRadioButton.Size = new System.Drawing.Size(52, 19);
            this.Parity_EvenRadioButton.TabIndex = 2;
            this.Parity_EvenRadioButton.Text = "Even";
            this.Parity_EvenRadioButton.UseVisualStyleBackColor = true;
            this.Parity_EvenRadioButton.CheckedChanged += new System.EventHandler(this.Parity_Changed);
            // 
            // Parity_OddRadioButton
            // 
            this.Parity_OddRadioButton.AutoSize = true;
            this.Parity_OddRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.Parity_OddRadioButton.Location = new System.Drawing.Point(11, 41);
            this.Parity_OddRadioButton.Name = "Parity_OddRadioButton";
            this.Parity_OddRadioButton.Size = new System.Drawing.Size(48, 19);
            this.Parity_OddRadioButton.TabIndex = 1;
            this.Parity_OddRadioButton.Text = "Odd";
            this.Parity_OddRadioButton.UseVisualStyleBackColor = true;
            this.Parity_OddRadioButton.CheckedChanged += new System.EventHandler(this.Parity_Changed);
            // 
            // Parity_NonRadioButton
            // 
            this.Parity_NonRadioButton.AutoSize = true;
            this.Parity_NonRadioButton.Checked = true;
            this.Parity_NonRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.Parity_NonRadioButton.Location = new System.Drawing.Point(11, 22);
            this.Parity_NonRadioButton.Name = "Parity_NonRadioButton";
            this.Parity_NonRadioButton.Size = new System.Drawing.Size(48, 19);
            this.Parity_NonRadioButton.TabIndex = 0;
            this.Parity_NonRadioButton.TabStop = true;
            this.Parity_NonRadioButton.Text = "Non";
            this.Parity_NonRadioButton.UseVisualStyleBackColor = true;
            this.Parity_NonRadioButton.CheckedChanged += new System.EventHandler(this.Parity_Changed);
            // 
            // Parity_GroupBox
            // 
            this.Parity_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.Parity_GroupBox.Controls.Add(this.Parity_NonRadioButton);
            this.Parity_GroupBox.Controls.Add(this.Parity_OddRadioButton);
            this.Parity_GroupBox.Controls.Add(this.Parity_EvenRadioButton);
            this.Parity_GroupBox.Controls.Add(this.Parity_MarkRadioButton);
            this.Parity_GroupBox.Controls.Add(this.Parity_SpaceRadioButton);
            this.Parity_GroupBox.Controls.Add(this.Parity_Separator);
            this.Parity_GroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Parity_GroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.Parity_GroupBox.Location = new System.Drawing.Point(634, 23);
            this.Parity_GroupBox.Name = "Parity_GroupBox";
            this.Parity_GroupBox.Size = new System.Drawing.Size(74, 125);
            this.Parity_GroupBox.TabIndex = 4;
            this.Parity_GroupBox.TabStop = false;
            this.Parity_GroupBox.Text = "Parity";
            // 
            // StopBit_Separator
            // 
            this.StopBit_Separator.BackColor = System.Drawing.Color.Transparent;
            this.StopBit_Separator.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.StopBit_Separator.LineThickness = 1;
            this.StopBit_Separator.Location = new System.Drawing.Point(11, 40);
            this.StopBit_Separator.Name = "StopBit_Separator";
            this.StopBit_Separator.Size = new System.Drawing.Size(10, 52);
            this.StopBit_Separator.TabIndex = 12;
            this.StopBit_Separator.Transparency = 255;
            this.StopBit_Separator.Vertical = true;
            // 
            // StopBit_1RadioButton
            // 
            this.StopBit_1RadioButton.AutoSize = true;
            this.StopBit_1RadioButton.Checked = true;
            this.StopBit_1RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.StopBit_1RadioButton.Location = new System.Drawing.Point(11, 40);
            this.StopBit_1RadioButton.Name = "StopBit_1RadioButton";
            this.StopBit_1RadioButton.Size = new System.Drawing.Size(32, 19);
            this.StopBit_1RadioButton.TabIndex = 0;
            this.StopBit_1RadioButton.TabStop = true;
            this.StopBit_1RadioButton.Text = "1";
            this.StopBit_1RadioButton.UseVisualStyleBackColor = true;
            this.StopBit_1RadioButton.CheckedChanged += new System.EventHandler(this.StopBit_Changed);
            // 
            // StopBit_2RadioButton
            // 
            this.StopBit_2RadioButton.AutoSize = true;
            this.StopBit_2RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.StopBit_2RadioButton.Location = new System.Drawing.Point(11, 73);
            this.StopBit_2RadioButton.Name = "StopBit_2RadioButton";
            this.StopBit_2RadioButton.Size = new System.Drawing.Size(32, 19);
            this.StopBit_2RadioButton.TabIndex = 1;
            this.StopBit_2RadioButton.Text = "2";
            this.StopBit_2RadioButton.UseVisualStyleBackColor = true;
            this.StopBit_2RadioButton.CheckedChanged += new System.EventHandler(this.StopBit_Changed);
            // 
            // StopBit_GroupBox
            // 
            this.StopBit_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.StopBit_GroupBox.Controls.Add(this.StopBit_2RadioButton);
            this.StopBit_GroupBox.Controls.Add(this.StopBit_1RadioButton);
            this.StopBit_GroupBox.Controls.Add(this.StopBit_Separator);
            this.StopBit_GroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StopBit_GroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.StopBit_GroupBox.Location = new System.Drawing.Point(714, 23);
            this.StopBit_GroupBox.Name = "StopBit_GroupBox";
            this.StopBit_GroupBox.Size = new System.Drawing.Size(74, 125);
            this.StopBit_GroupBox.TabIndex = 5;
            this.StopBit_GroupBox.TabStop = false;
            this.StopBit_GroupBox.Text = "Stop Bits";
            // 
            // DataReceived_ClearBtn
            // 
            this.DataReceived_ClearBtn.Active = false;
            this.DataReceived_ClearBtn.Activecolor = System.Drawing.Color.DimGray;
            this.DataReceived_ClearBtn.BackColor = System.Drawing.Color.DimGray;
            this.DataReceived_ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DataReceived_ClearBtn.BorderRadius = 5;
            this.DataReceived_ClearBtn.ButtonText = "Clear";
            this.DataReceived_ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataReceived_ClearBtn.DisabledColor = System.Drawing.Color.DimGray;
            this.DataReceived_ClearBtn.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.DataReceived_ClearBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DataReceived_ClearBtn.Iconimage = null;
            this.DataReceived_ClearBtn.Iconimage_right = null;
            this.DataReceived_ClearBtn.Iconimage_right_Selected = null;
            this.DataReceived_ClearBtn.Iconimage_Selected = null;
            this.DataReceived_ClearBtn.IconMarginLeft = 0;
            this.DataReceived_ClearBtn.IconMarginRight = 0;
            this.DataReceived_ClearBtn.IconRightVisible = true;
            this.DataReceived_ClearBtn.IconRightZoom = 0D;
            this.DataReceived_ClearBtn.IconVisible = true;
            this.DataReceived_ClearBtn.IconZoom = 90D;
            this.DataReceived_ClearBtn.IsTab = false;
            this.DataReceived_ClearBtn.Location = new System.Drawing.Point(164, 162);
            this.DataReceived_ClearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataReceived_ClearBtn.Name = "DataReceived_ClearBtn";
            this.DataReceived_ClearBtn.Normalcolor = System.Drawing.Color.DimGray;
            this.DataReceived_ClearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DataReceived_ClearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DataReceived_ClearBtn.selected = false;
            this.DataReceived_ClearBtn.Size = new System.Drawing.Size(77, 21);
            this.DataReceived_ClearBtn.TabIndex = 7;
            this.DataReceived_ClearBtn.Text = "Clear";
            this.DataReceived_ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataReceived_ClearBtn.Textcolor = System.Drawing.Color.White;
            this.DataReceived_ClearBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataReceived_ClearBtn.Click += new System.EventHandler(this.DataReceived_ClearBtn_Click);
            // 
            // DataReceived_ExportBtn
            // 
            this.DataReceived_ExportBtn.Active = false;
            this.DataReceived_ExportBtn.Activecolor = System.Drawing.Color.DimGray;
            this.DataReceived_ExportBtn.BackColor = System.Drawing.Color.DimGray;
            this.DataReceived_ExportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DataReceived_ExportBtn.BorderRadius = 5;
            this.DataReceived_ExportBtn.ButtonText = "Export";
            this.DataReceived_ExportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataReceived_ExportBtn.DisabledColor = System.Drawing.Color.DimGray;
            this.DataReceived_ExportBtn.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.DataReceived_ExportBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DataReceived_ExportBtn.Iconimage = null;
            this.DataReceived_ExportBtn.Iconimage_right = null;
            this.DataReceived_ExportBtn.Iconimage_right_Selected = null;
            this.DataReceived_ExportBtn.Iconimage_Selected = null;
            this.DataReceived_ExportBtn.IconMarginLeft = 0;
            this.DataReceived_ExportBtn.IconMarginRight = 0;
            this.DataReceived_ExportBtn.IconRightVisible = true;
            this.DataReceived_ExportBtn.IconRightZoom = 0D;
            this.DataReceived_ExportBtn.IconVisible = true;
            this.DataReceived_ExportBtn.IconZoom = 90D;
            this.DataReceived_ExportBtn.IsTab = false;
            this.DataReceived_ExportBtn.Location = new System.Drawing.Point(245, 162);
            this.DataReceived_ExportBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataReceived_ExportBtn.Name = "DataReceived_ExportBtn";
            this.DataReceived_ExportBtn.Normalcolor = System.Drawing.Color.DimGray;
            this.DataReceived_ExportBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DataReceived_ExportBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DataReceived_ExportBtn.selected = false;
            this.DataReceived_ExportBtn.Size = new System.Drawing.Size(77, 21);
            this.DataReceived_ExportBtn.TabIndex = 8;
            this.DataReceived_ExportBtn.Text = "Export";
            this.DataReceived_ExportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataReceived_ExportBtn.Textcolor = System.Drawing.Color.White;
            this.DataReceived_ExportBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataReceived_ExportBtn.Click += new System.EventHandler(this.DataReceived_ExportBtn_Click);
            // 
            // DataSend_ExportBtn
            // 
            this.DataSend_ExportBtn.Active = false;
            this.DataSend_ExportBtn.Activecolor = System.Drawing.Color.DimGray;
            this.DataSend_ExportBtn.BackColor = System.Drawing.Color.DimGray;
            this.DataSend_ExportBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DataSend_ExportBtn.BorderRadius = 5;
            this.DataSend_ExportBtn.ButtonText = "Export";
            this.DataSend_ExportBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataSend_ExportBtn.DisabledColor = System.Drawing.Color.DimGray;
            this.DataSend_ExportBtn.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.DataSend_ExportBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DataSend_ExportBtn.Iconimage = null;
            this.DataSend_ExportBtn.Iconimage_right = null;
            this.DataSend_ExportBtn.Iconimage_right_Selected = null;
            this.DataSend_ExportBtn.Iconimage_Selected = null;
            this.DataSend_ExportBtn.IconMarginLeft = 0;
            this.DataSend_ExportBtn.IconMarginRight = 0;
            this.DataSend_ExportBtn.IconRightVisible = true;
            this.DataSend_ExportBtn.IconRightZoom = 0D;
            this.DataSend_ExportBtn.IconVisible = true;
            this.DataSend_ExportBtn.IconZoom = 90D;
            this.DataSend_ExportBtn.IsTab = false;
            this.DataSend_ExportBtn.Location = new System.Drawing.Point(245, 333);
            this.DataSend_ExportBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataSend_ExportBtn.Name = "DataSend_ExportBtn";
            this.DataSend_ExportBtn.Normalcolor = System.Drawing.Color.DimGray;
            this.DataSend_ExportBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DataSend_ExportBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DataSend_ExportBtn.selected = false;
            this.DataSend_ExportBtn.Size = new System.Drawing.Size(77, 21);
            this.DataSend_ExportBtn.TabIndex = 13;
            this.DataSend_ExportBtn.Text = "Export";
            this.DataSend_ExportBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataSend_ExportBtn.Textcolor = System.Drawing.Color.White;
            this.DataSend_ExportBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSend_ExportBtn.Click += new System.EventHandler(this.DataSend_ExportBtn_Click);
            // 
            // BaudRate_GroupBox
            // 
            this.BaudRate_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_57600RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_115200RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_128000RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_256000RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_14400RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_19200RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_28800RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_38400RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_56000RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_600RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_1200RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_2400RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_4800RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.BaudRate_9600RadioButton);
            this.BaudRate_GroupBox.Controls.Add(this.bunifuSeparator1);
            this.BaudRate_GroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRate_GroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.BaudRate_GroupBox.Location = new System.Drawing.Point(327, 23);
            this.BaudRate_GroupBox.Name = "BaudRate_GroupBox";
            this.BaudRate_GroupBox.Size = new System.Drawing.Size(221, 125);
            this.BaudRate_GroupBox.TabIndex = 2;
            this.BaudRate_GroupBox.TabStop = false;
            this.BaudRate_GroupBox.Text = "Baud Rate";
            // 
            // BaudRate_57600RadioButton
            // 
            this.BaudRate_57600RadioButton.AutoSize = true;
            this.BaudRate_57600RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.BaudRate_57600RadioButton.Location = new System.Drawing.Point(145, 22);
            this.BaudRate_57600RadioButton.Name = "BaudRate_57600RadioButton";
            this.BaudRate_57600RadioButton.Size = new System.Drawing.Size(60, 19);
            this.BaudRate_57600RadioButton.TabIndex = 10;
            this.BaudRate_57600RadioButton.Text = "57600";
            this.BaudRate_57600RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_57600RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_115200RadioButton
            // 
            this.BaudRate_115200RadioButton.AutoSize = true;
            this.BaudRate_115200RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.BaudRate_115200RadioButton.Location = new System.Drawing.Point(145, 41);
            this.BaudRate_115200RadioButton.Name = "BaudRate_115200RadioButton";
            this.BaudRate_115200RadioButton.Size = new System.Drawing.Size(67, 19);
            this.BaudRate_115200RadioButton.TabIndex = 11;
            this.BaudRate_115200RadioButton.Text = "115200";
            this.BaudRate_115200RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_115200RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_128000RadioButton
            // 
            this.BaudRate_128000RadioButton.AutoSize = true;
            this.BaudRate_128000RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.BaudRate_128000RadioButton.Location = new System.Drawing.Point(145, 60);
            this.BaudRate_128000RadioButton.Name = "BaudRate_128000RadioButton";
            this.BaudRate_128000RadioButton.Size = new System.Drawing.Size(67, 19);
            this.BaudRate_128000RadioButton.TabIndex = 12;
            this.BaudRate_128000RadioButton.Text = "128000";
            this.BaudRate_128000RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_128000RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_256000RadioButton
            // 
            this.BaudRate_256000RadioButton.AutoSize = true;
            this.BaudRate_256000RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.BaudRate_256000RadioButton.Location = new System.Drawing.Point(145, 79);
            this.BaudRate_256000RadioButton.Name = "BaudRate_256000RadioButton";
            this.BaudRate_256000RadioButton.Size = new System.Drawing.Size(67, 19);
            this.BaudRate_256000RadioButton.TabIndex = 13;
            this.BaudRate_256000RadioButton.Text = "256000";
            this.BaudRate_256000RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_256000RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_14400RadioButton
            // 
            this.BaudRate_14400RadioButton.AccessibleDescription = "";
            this.BaudRate_14400RadioButton.AutoSize = true;
            this.BaudRate_14400RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.BaudRate_14400RadioButton.Location = new System.Drawing.Point(71, 22);
            this.BaudRate_14400RadioButton.Name = "BaudRate_14400RadioButton";
            this.BaudRate_14400RadioButton.Size = new System.Drawing.Size(60, 19);
            this.BaudRate_14400RadioButton.TabIndex = 5;
            this.BaudRate_14400RadioButton.Text = "14400";
            this.BaudRate_14400RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_14400RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_19200RadioButton
            // 
            this.BaudRate_19200RadioButton.AutoSize = true;
            this.BaudRate_19200RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.BaudRate_19200RadioButton.Location = new System.Drawing.Point(71, 41);
            this.BaudRate_19200RadioButton.Name = "BaudRate_19200RadioButton";
            this.BaudRate_19200RadioButton.Size = new System.Drawing.Size(60, 19);
            this.BaudRate_19200RadioButton.TabIndex = 6;
            this.BaudRate_19200RadioButton.Text = "19200";
            this.BaudRate_19200RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_19200RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_28800RadioButton
            // 
            this.BaudRate_28800RadioButton.AutoSize = true;
            this.BaudRate_28800RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.BaudRate_28800RadioButton.Location = new System.Drawing.Point(71, 60);
            this.BaudRate_28800RadioButton.Name = "BaudRate_28800RadioButton";
            this.BaudRate_28800RadioButton.Size = new System.Drawing.Size(60, 19);
            this.BaudRate_28800RadioButton.TabIndex = 7;
            this.BaudRate_28800RadioButton.Text = "28800";
            this.BaudRate_28800RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_28800RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_38400RadioButton
            // 
            this.BaudRate_38400RadioButton.AutoSize = true;
            this.BaudRate_38400RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.BaudRate_38400RadioButton.Location = new System.Drawing.Point(71, 79);
            this.BaudRate_38400RadioButton.Name = "BaudRate_38400RadioButton";
            this.BaudRate_38400RadioButton.Size = new System.Drawing.Size(60, 19);
            this.BaudRate_38400RadioButton.TabIndex = 8;
            this.BaudRate_38400RadioButton.Text = "38400";
            this.BaudRate_38400RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_38400RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_56000RadioButton
            // 
            this.BaudRate_56000RadioButton.AutoSize = true;
            this.BaudRate_56000RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.BaudRate_56000RadioButton.Location = new System.Drawing.Point(71, 98);
            this.BaudRate_56000RadioButton.Name = "BaudRate_56000RadioButton";
            this.BaudRate_56000RadioButton.Size = new System.Drawing.Size(60, 19);
            this.BaudRate_56000RadioButton.TabIndex = 9;
            this.BaudRate_56000RadioButton.Text = "56000";
            this.BaudRate_56000RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_56000RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_600RadioButton
            // 
            this.BaudRate_600RadioButton.AutoSize = true;
            this.BaudRate_600RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.BaudRate_600RadioButton.Location = new System.Drawing.Point(11, 22);
            this.BaudRate_600RadioButton.Name = "BaudRate_600RadioButton";
            this.BaudRate_600RadioButton.Size = new System.Drawing.Size(46, 19);
            this.BaudRate_600RadioButton.TabIndex = 0;
            this.BaudRate_600RadioButton.Text = "600";
            this.BaudRate_600RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_600RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_1200RadioButton
            // 
            this.BaudRate_1200RadioButton.AutoSize = true;
            this.BaudRate_1200RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.BaudRate_1200RadioButton.Location = new System.Drawing.Point(11, 41);
            this.BaudRate_1200RadioButton.Name = "BaudRate_1200RadioButton";
            this.BaudRate_1200RadioButton.Size = new System.Drawing.Size(53, 19);
            this.BaudRate_1200RadioButton.TabIndex = 1;
            this.BaudRate_1200RadioButton.Text = "1200";
            this.BaudRate_1200RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_1200RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_2400RadioButton
            // 
            this.BaudRate_2400RadioButton.AutoSize = true;
            this.BaudRate_2400RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.BaudRate_2400RadioButton.Location = new System.Drawing.Point(11, 60);
            this.BaudRate_2400RadioButton.Name = "BaudRate_2400RadioButton";
            this.BaudRate_2400RadioButton.Size = new System.Drawing.Size(53, 19);
            this.BaudRate_2400RadioButton.TabIndex = 2;
            this.BaudRate_2400RadioButton.Text = "2400";
            this.BaudRate_2400RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_2400RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_4800RadioButton
            // 
            this.BaudRate_4800RadioButton.AutoSize = true;
            this.BaudRate_4800RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.BaudRate_4800RadioButton.Location = new System.Drawing.Point(11, 79);
            this.BaudRate_4800RadioButton.Name = "BaudRate_4800RadioButton";
            this.BaudRate_4800RadioButton.Size = new System.Drawing.Size(53, 19);
            this.BaudRate_4800RadioButton.TabIndex = 3;
            this.BaudRate_4800RadioButton.Text = "4800";
            this.BaudRate_4800RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_4800RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // BaudRate_9600RadioButton
            // 
            this.BaudRate_9600RadioButton.AutoSize = true;
            this.BaudRate_9600RadioButton.Checked = true;
            this.BaudRate_9600RadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.BaudRate_9600RadioButton.Location = new System.Drawing.Point(11, 98);
            this.BaudRate_9600RadioButton.Name = "BaudRate_9600RadioButton";
            this.BaudRate_9600RadioButton.Size = new System.Drawing.Size(53, 19);
            this.BaudRate_9600RadioButton.TabIndex = 4;
            this.BaudRate_9600RadioButton.TabStop = true;
            this.BaudRate_9600RadioButton.Text = "9600";
            this.BaudRate_9600RadioButton.UseVisualStyleBackColor = true;
            this.BaudRate_9600RadioButton.CheckedChanged += new System.EventHandler(this.BaudRate_Changed);
            // 
            // bunifuSeparator1
            // 
            this.bunifuSeparator1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator1.LineThickness = 1;
            this.bunifuSeparator1.Location = new System.Drawing.Point(11, 22);
            this.bunifuSeparator1.Name = "bunifuSeparator1";
            this.bunifuSeparator1.Size = new System.Drawing.Size(10, 94);
            this.bunifuSeparator1.TabIndex = 13;
            this.bunifuSeparator1.Transparency = 255;
            this.bunifuSeparator1.Vertical = true;
            // 
            // ComPort_ComboBox
            // 
            this.ComPort_ComboBox.BackColor = System.Drawing.Color.White;
            this.ComPort_ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.ComPort_ComboBox.FormattingEnabled = true;
            this.ComPort_ComboBox.Location = new System.Drawing.Point(6, 22);
            this.ComPort_ComboBox.Name = "ComPort_ComboBox";
            this.ComPort_ComboBox.Size = new System.Drawing.Size(145, 23);
            this.ComPort_ComboBox.TabIndex = 0;
            // 
            // ComPort_GroupBox
            // 
            this.ComPort_GroupBox.BackColor = System.Drawing.Color.Transparent;
            this.ComPort_GroupBox.Controls.Add(this.ComPort_ComboBox);
            this.ComPort_GroupBox.Controls.Add(this.ComPort_ScanBtn);
            this.ComPort_GroupBox.Controls.Add(this.ComPort_ConnectBtn);
            this.ComPort_GroupBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComPort_GroupBox.ForeColor = System.Drawing.Color.DimGray;
            this.ComPort_GroupBox.Location = new System.Drawing.Point(164, 23);
            this.ComPort_GroupBox.Name = "ComPort_GroupBox";
            this.ComPort_GroupBox.Size = new System.Drawing.Size(157, 125);
            this.ComPort_GroupBox.TabIndex = 1;
            this.ComPort_GroupBox.TabStop = false;
            this.ComPort_GroupBox.Text = "COM Port";
            // 
            // DataSend_ClearBtn
            // 
            this.DataSend_ClearBtn.Active = false;
            this.DataSend_ClearBtn.Activecolor = System.Drawing.Color.DimGray;
            this.DataSend_ClearBtn.BackColor = System.Drawing.Color.DimGray;
            this.DataSend_ClearBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DataSend_ClearBtn.BorderRadius = 5;
            this.DataSend_ClearBtn.ButtonText = "Clear";
            this.DataSend_ClearBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataSend_ClearBtn.DisabledColor = System.Drawing.Color.DimGray;
            this.DataSend_ClearBtn.Font = new System.Drawing.Font("Segoe UI", 7F);
            this.DataSend_ClearBtn.Iconcolor = System.Drawing.Color.Transparent;
            this.DataSend_ClearBtn.Iconimage = null;
            this.DataSend_ClearBtn.Iconimage_right = null;
            this.DataSend_ClearBtn.Iconimage_right_Selected = null;
            this.DataSend_ClearBtn.Iconimage_Selected = null;
            this.DataSend_ClearBtn.IconMarginLeft = 0;
            this.DataSend_ClearBtn.IconMarginRight = 0;
            this.DataSend_ClearBtn.IconRightVisible = true;
            this.DataSend_ClearBtn.IconRightZoom = 0D;
            this.DataSend_ClearBtn.IconVisible = true;
            this.DataSend_ClearBtn.IconZoom = 90D;
            this.DataSend_ClearBtn.IsTab = false;
            this.DataSend_ClearBtn.Location = new System.Drawing.Point(164, 333);
            this.DataSend_ClearBtn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.DataSend_ClearBtn.Name = "DataSend_ClearBtn";
            this.DataSend_ClearBtn.Normalcolor = System.Drawing.Color.DimGray;
            this.DataSend_ClearBtn.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.DataSend_ClearBtn.OnHoverTextColor = System.Drawing.Color.White;
            this.DataSend_ClearBtn.selected = false;
            this.DataSend_ClearBtn.Size = new System.Drawing.Size(77, 21);
            this.DataSend_ClearBtn.TabIndex = 12;
            this.DataSend_ClearBtn.Text = "Clear";
            this.DataSend_ClearBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataSend_ClearBtn.Textcolor = System.Drawing.Color.White;
            this.DataSend_ClearBtn.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSend_ClearBtn.Click += new System.EventHandler(this.DataSend_ClearBtn_Click);
            // 
            // SerialPort_SendDataListBox
            // 
            this.SerialPort_SendDataListBox.BackColor = System.Drawing.Color.White;
            this.SerialPort_SendDataListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SerialPort_SendDataListBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.SerialPort_SendDataListBox.ForeColor = System.Drawing.Color.DimGray;
            this.SerialPort_SendDataListBox.FormattingEnabled = true;
            this.SerialPort_SendDataListBox.Location = new System.Drawing.Point(164, 360);
            this.SerialPort_SendDataListBox.Name = "SerialPort_SendDataListBox";
            this.SerialPort_SendDataListBox.Size = new System.Drawing.Size(774, 80);
            this.SerialPort_SendDataListBox.TabIndex = 18;
            this.SerialPort_SendDataListBox.SelectedIndexChanged += new System.EventHandler(this.SerialPort_SendDataListBox_SelectedIndexChanged);
            // 
            // SerialPort_SendDataTxtBox
            // 
            this.SerialPort_SendDataTxtBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SerialPort_SendDataTxtBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SerialPort_SendDataTxtBox.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SerialPort_SendDataTxtBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SerialPort_SendDataTxtBox.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.SerialPort_SendDataTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(8)))), ((int)(((byte)(95)))));
            this.SerialPort_SendDataTxtBox.HintForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.SerialPort_SendDataTxtBox.HintText = "Click To Write Your Data";
            this.SerialPort_SendDataTxtBox.isPassword = false;
            this.SerialPort_SendDataTxtBox.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(8)))), ((int)(((byte)(95)))));
            this.SerialPort_SendDataTxtBox.LineIdleColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.SerialPort_SendDataTxtBox.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(58)))), ((int)(((byte)(95)))));
            this.SerialPort_SendDataTxtBox.LineThickness = 1;
            this.SerialPort_SendDataTxtBox.Location = new System.Drawing.Point(328, 333);
            this.SerialPort_SendDataTxtBox.Margin = new System.Windows.Forms.Padding(4);
            this.SerialPort_SendDataTxtBox.MaxLength = 32767;
            this.SerialPort_SendDataTxtBox.Name = "SerialPort_SendDataTxtBox";
            this.SerialPort_SendDataTxtBox.Size = new System.Drawing.Size(337, 21);
            this.SerialPort_SendDataTxtBox.TabIndex = 14;
            this.SerialPort_SendDataTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.SerialPort_SendDataTxtBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SerialPort_SendDataTxtBox_KeyDown);
            // 
            // SerialPort_ReceivedDataTxtBox
            // 
            this.SerialPort_ReceivedDataTxtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SerialPort_ReceivedDataTxtBox.BackColor = System.Drawing.Color.White;
            this.SerialPort_ReceivedDataTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SerialPort_ReceivedDataTxtBox.EnableAutoDragDrop = true;
            this.SerialPort_ReceivedDataTxtBox.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.SerialPort_ReceivedDataTxtBox.ForeColor = System.Drawing.Color.DimGray;
            this.SerialPort_ReceivedDataTxtBox.Location = new System.Drawing.Point(165, 190);
            this.SerialPort_ReceivedDataTxtBox.Name = "SerialPort_ReceivedDataTxtBox";
            this.SerialPort_ReceivedDataTxtBox.ReadOnly = true;
            this.SerialPort_ReceivedDataTxtBox.Size = new System.Drawing.Size(772, 129);
            this.SerialPort_ReceivedDataTxtBox.TabIndex = 11;
            this.SerialPort_ReceivedDataTxtBox.Text = "";
            // 
            // SendWithCRCheckBox
            // 
            this.SendWithCRCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.SendWithCRCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.SendWithCRCheckBox.Checked = false;
            this.SendWithCRCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(8)))), ((int)(((byte)(95)))));
            this.SendWithCRCheckBox.ForeColor = System.Drawing.Color.White;
            this.SendWithCRCheckBox.Location = new System.Drawing.Point(672, 335);
            this.SendWithCRCheckBox.Name = "SendWithCRCheckBox";
            this.SendWithCRCheckBox.Size = new System.Drawing.Size(20, 20);
            this.SendWithCRCheckBox.TabIndex = 15;
            // 
            // SendWithLFCheckBox
            // 
            this.SendWithLFCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.SendWithLFCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.SendWithLFCheckBox.Checked = false;
            this.SendWithLFCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(8)))), ((int)(((byte)(95)))));
            this.SendWithLFCheckBox.ForeColor = System.Drawing.Color.White;
            this.SendWithLFCheckBox.Location = new System.Drawing.Point(726, 335);
            this.SendWithLFCheckBox.Name = "SendWithLFCheckBox";
            this.SendWithLFCheckBox.Size = new System.Drawing.Size(20, 20);
            this.SendWithLFCheckBox.TabIndex = 16;
            // 
            // SendWithCRLbl
            // 
            this.SendWithCRLbl.AutoSize = true;
            this.SendWithCRLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SendWithCRLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.SendWithCRLbl.Location = new System.Drawing.Point(690, 338);
            this.SendWithCRLbl.Name = "SendWithCRLbl";
            this.SendWithCRLbl.Size = new System.Drawing.Size(30, 15);
            this.SendWithCRLbl.TabIndex = 27;
            this.SendWithCRLbl.Text = "+CR";
            // 
            // SendWithLFLbl
            // 
            this.SendWithLFLbl.AutoSize = true;
            this.SendWithLFLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SendWithLFLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.SendWithLFLbl.Location = new System.Drawing.Point(743, 338);
            this.SendWithLFLbl.Name = "SendWithLFLbl";
            this.SendWithLFLbl.Size = new System.Drawing.Size(27, 15);
            this.SendWithLFLbl.TabIndex = 28;
            this.SendWithLFLbl.Text = "+LF";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.Handshake_RTS_CTS_XOnXOffRadioButton);
            this.groupBox1.Controls.Add(this.Handshake_RTS_CTSRadioButton);
            this.groupBox1.Controls.Add(this.Handshake_XOnXOffRadioButton);
            this.groupBox1.Controls.Add(this.Handshake_NonRadioButton);
            this.groupBox1.Controls.Add(this.bunifuSeparator2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.DimGray;
            this.groupBox1.Location = new System.Drawing.Point(794, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(144, 125);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Handshake";
            // 
            // Handshake_RTS_CTS_XOnXOffRadioButton
            // 
            this.Handshake_RTS_CTS_XOnXOffRadioButton.AutoSize = true;
            this.Handshake_RTS_CTS_XOnXOffRadioButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.Handshake_RTS_CTS_XOnXOffRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.Handshake_RTS_CTS_XOnXOffRadioButton.Location = new System.Drawing.Point(11, 97);
            this.Handshake_RTS_CTS_XOnXOffRadioButton.Name = "Handshake_RTS_CTS_XOnXOffRadioButton";
            this.Handshake_RTS_CTS_XOnXOffRadioButton.Size = new System.Drawing.Size(121, 17);
            this.Handshake_RTS_CTS_XOnXOffRadioButton.TabIndex = 3;
            this.Handshake_RTS_CTS_XOnXOffRadioButton.Text = "RTS/CTS+XOnXOff";
            this.Handshake_RTS_CTS_XOnXOffRadioButton.UseVisualStyleBackColor = true;
            this.Handshake_RTS_CTS_XOnXOffRadioButton.CheckedChanged += new System.EventHandler(this.Handshake_Changed);
            // 
            // Handshake_RTS_CTSRadioButton
            // 
            this.Handshake_RTS_CTSRadioButton.AutoSize = true;
            this.Handshake_RTS_CTSRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.Handshake_RTS_CTSRadioButton.Location = new System.Drawing.Point(11, 72);
            this.Handshake_RTS_CTSRadioButton.Name = "Handshake_RTS_CTSRadioButton";
            this.Handshake_RTS_CTSRadioButton.Size = new System.Drawing.Size(73, 19);
            this.Handshake_RTS_CTSRadioButton.TabIndex = 2;
            this.Handshake_RTS_CTSRadioButton.Text = "RTS/CTS";
            this.Handshake_RTS_CTSRadioButton.UseVisualStyleBackColor = true;
            this.Handshake_RTS_CTSRadioButton.CheckedChanged += new System.EventHandler(this.Handshake_Changed);
            // 
            // Handshake_XOnXOffRadioButton
            // 
            this.Handshake_XOnXOffRadioButton.AutoSize = true;
            this.Handshake_XOnXOffRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.Handshake_XOnXOffRadioButton.Location = new System.Drawing.Point(11, 47);
            this.Handshake_XOnXOffRadioButton.Name = "Handshake_XOnXOffRadioButton";
            this.Handshake_XOnXOffRadioButton.Size = new System.Drawing.Size(76, 19);
            this.Handshake_XOnXOffRadioButton.TabIndex = 1;
            this.Handshake_XOnXOffRadioButton.Text = "XOnXOff";
            this.Handshake_XOnXOffRadioButton.UseVisualStyleBackColor = true;
            this.Handshake_XOnXOffRadioButton.CheckedChanged += new System.EventHandler(this.Handshake_Changed);
            // 
            // Handshake_NonRadioButton
            // 
            this.Handshake_NonRadioButton.AutoSize = true;
            this.Handshake_NonRadioButton.Checked = true;
            this.Handshake_NonRadioButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.Handshake_NonRadioButton.Location = new System.Drawing.Point(11, 22);
            this.Handshake_NonRadioButton.Name = "Handshake_NonRadioButton";
            this.Handshake_NonRadioButton.Size = new System.Drawing.Size(48, 19);
            this.Handshake_NonRadioButton.TabIndex = 0;
            this.Handshake_NonRadioButton.TabStop = true;
            this.Handshake_NonRadioButton.Text = "Non";
            this.Handshake_NonRadioButton.UseVisualStyleBackColor = true;
            this.Handshake_NonRadioButton.CheckedChanged += new System.EventHandler(this.Handshake_Changed);
            // 
            // bunifuSeparator2
            // 
            this.bunifuSeparator2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuSeparator2.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.bunifuSeparator2.LineThickness = 1;
            this.bunifuSeparator2.Location = new System.Drawing.Point(11, 22);
            this.bunifuSeparator2.Name = "bunifuSeparator2";
            this.bunifuSeparator2.Size = new System.Drawing.Size(10, 92);
            this.bunifuSeparator2.TabIndex = 13;
            this.bunifuSeparator2.Transparency = 255;
            this.bunifuSeparator2.Vertical = true;
            // 
            // SerialPort_DtrCheckBox
            // 
            this.SerialPort_DtrCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.SerialPort_DtrCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.SerialPort_DtrCheckBox.Checked = false;
            this.SerialPort_DtrCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(155)))), ((int)(((byte)(75)))));
            this.SerialPort_DtrCheckBox.ForeColor = System.Drawing.Color.White;
            this.SerialPort_DtrCheckBox.Location = new System.Drawing.Point(881, 162);
            this.SerialPort_DtrCheckBox.Name = "SerialPort_DtrCheckBox";
            this.SerialPort_DtrCheckBox.Size = new System.Drawing.Size(20, 20);
            this.SerialPort_DtrCheckBox.TabIndex = 10;
            this.SerialPort_DtrCheckBox.OnChange += new System.EventHandler(this.SerialPort_DtrCheckBox_OnChange);
            // 
            // SerialPort_RtsCheckBox
            // 
            this.SerialPort_RtsCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.SerialPort_RtsCheckBox.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.SerialPort_RtsCheckBox.Checked = false;
            this.SerialPort_RtsCheckBox.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(154)))), ((int)(((byte)(255)))));
            this.SerialPort_RtsCheckBox.ForeColor = System.Drawing.Color.White;
            this.SerialPort_RtsCheckBox.Location = new System.Drawing.Point(794, 162);
            this.SerialPort_RtsCheckBox.Name = "SerialPort_RtsCheckBox";
            this.SerialPort_RtsCheckBox.Size = new System.Drawing.Size(20, 20);
            this.SerialPort_RtsCheckBox.TabIndex = 9;
            this.SerialPort_RtsCheckBox.OnChange += new System.EventHandler(this.SerialPort_RtsCheckBox_OnChange);
            // 
            // SerialPort_RtsLbl
            // 
            this.SerialPort_RtsLbl.AutoSize = true;
            this.SerialPort_RtsLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SerialPort_RtsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.SerialPort_RtsLbl.Location = new System.Drawing.Point(820, 165);
            this.SerialPort_RtsLbl.Name = "SerialPort_RtsLbl";
            this.SerialPort_RtsLbl.Size = new System.Drawing.Size(29, 15);
            this.SerialPort_RtsLbl.TabIndex = 32;
            this.SerialPort_RtsLbl.Text = "RTS";
            // 
            // SerialPort_DtrLbl
            // 
            this.SerialPort_DtrLbl.AutoSize = true;
            this.SerialPort_DtrLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.SerialPort_DtrLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.SerialPort_DtrLbl.Location = new System.Drawing.Point(907, 165);
            this.SerialPort_DtrLbl.Name = "SerialPort_DtrLbl";
            this.SerialPort_DtrLbl.Size = new System.Drawing.Size(31, 15);
            this.SerialPort_DtrLbl.TabIndex = 33;
            this.SerialPort_DtrLbl.Text = "DTR";
            // 
            // MinimizePicBox
            // 
            this.MinimizePicBox.Image = global::Terminal.Properties.Resources.Minimize_Icon;
            this.MinimizePicBox.InitialImage = global::Terminal.Properties.Resources.Minimize_Icon;
            this.MinimizePicBox.Location = new System.Drawing.Point(879, 7);
            this.MinimizePicBox.Name = "MinimizePicBox";
            this.MinimizePicBox.Size = new System.Drawing.Size(17, 13);
            this.MinimizePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.MinimizePicBox.TabIndex = 35;
            this.MinimizePicBox.TabStop = false;
            this.MinimizePicBox.Click += new System.EventHandler(this.MinimizePicBox_Click);
            // 
            // ClosePicBox
            // 
            this.ClosePicBox.Image = global::Terminal.Properties.Resources.Close_Icon;
            this.ClosePicBox.InitialImage = global::Terminal.Properties.Resources.Close_Icon;
            this.ClosePicBox.Location = new System.Drawing.Point(911, 7);
            this.ClosePicBox.Name = "ClosePicBox";
            this.ClosePicBox.Size = new System.Drawing.Size(13, 13);
            this.ClosePicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ClosePicBox.TabIndex = 34;
            this.ClosePicBox.TabStop = false;
            this.ClosePicBox.Click += new System.EventHandler(this.Panel_ExitThinButton_Click);
            // 
            // DataSend_SendBtn
            // 
            this.DataSend_SendBtn.ActiveBorderThickness = 1;
            this.DataSend_SendBtn.ActiveCornerRadius = 5;
            this.DataSend_SendBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.DataSend_SendBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(8)))), ((int)(((byte)(95)))));
            this.DataSend_SendBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(8)))), ((int)(((byte)(95)))));
            this.DataSend_SendBtn.BackColor = System.Drawing.Color.White;
            this.DataSend_SendBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataSend_SendBtn.BackgroundImage")));
            this.DataSend_SendBtn.ButtonText = "Send";
            this.DataSend_SendBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataSend_SendBtn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSend_SendBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DataSend_SendBtn.IdleBorderThickness = 1;
            this.DataSend_SendBtn.IdleCornerRadius = 5;
            this.DataSend_SendBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.DataSend_SendBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.DataSend_SendBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.DataSend_SendBtn.Location = new System.Drawing.Point(861, 328);
            this.DataSend_SendBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DataSend_SendBtn.Name = "DataSend_SendBtn";
            this.DataSend_SendBtn.Size = new System.Drawing.Size(77, 31);
            this.DataSend_SendBtn.TabIndex = 17;
            this.DataSend_SendBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataSend_SendBtn.Click += new System.EventHandler(this.DataSend_SendBtn_Click);
            // 
            // ControlPanel
            // 
            this.ControlPanel.BackColor = System.Drawing.Color.Transparent;
            this.ControlPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ControlPanel.BackgroundImage")));
            this.ControlPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ControlPanel.Controls.Add(this.Panel_AsciiThinButton);
            this.ControlPanel.Controls.Add(this.VersionLbl);
            this.ControlPanel.Controls.Add(this.bunifuCustomLabel1);
            this.ControlPanel.Controls.Add(this.Panel_AboutThinButton);
            this.ControlPanel.Controls.Add(this.Panel_Logo);
            this.ControlPanel.Controls.Add(this.Panel_HelpThinButton);
            this.ControlPanel.Controls.Add(this.Panel_ExitThinButton);
            this.ControlPanel.GradientBottomLeft = System.Drawing.Color.White;
            this.ControlPanel.GradientBottomRight = System.Drawing.Color.White;
            this.ControlPanel.GradientTopLeft = System.Drawing.Color.White;
            this.ControlPanel.GradientTopRight = System.Drawing.Color.White;
            this.ControlPanel.Location = new System.Drawing.Point(2, 2);
            this.ControlPanel.Name = "ControlPanel";
            this.ControlPanel.Quality = 10;
            this.ControlPanel.Size = new System.Drawing.Size(148, 446);
            this.ControlPanel.TabIndex = 0;
            // 
            // Panel_AsciiThinButton
            // 
            this.Panel_AsciiThinButton.ActiveBorderThickness = 1;
            this.Panel_AsciiThinButton.ActiveCornerRadius = 5;
            this.Panel_AsciiThinButton.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Panel_AsciiThinButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.Panel_AsciiThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(195)))), ((int)(((byte)(75)))));
            this.Panel_AsciiThinButton.BackColor = System.Drawing.Color.Transparent;
            this.Panel_AsciiThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_AsciiThinButton.BackgroundImage")));
            this.Panel_AsciiThinButton.ButtonText = "ASCII Table";
            this.Panel_AsciiThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_AsciiThinButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_AsciiThinButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.Panel_AsciiThinButton.IdleBorderThickness = 1;
            this.Panel_AsciiThinButton.IdleCornerRadius = 5;
            this.Panel_AsciiThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.Panel_AsciiThinButton.IdleForecolor = System.Drawing.Color.DimGray;
            this.Panel_AsciiThinButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.Panel_AsciiThinButton.Location = new System.Drawing.Point(14, 163);
            this.Panel_AsciiThinButton.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_AsciiThinButton.Name = "Panel_AsciiThinButton";
            this.Panel_AsciiThinButton.Size = new System.Drawing.Size(120, 40);
            this.Panel_AsciiThinButton.TabIndex = 1;
            this.Panel_AsciiThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Panel_AsciiThinButton.Click += new System.EventHandler(this.Panel_AsciiThinButton_Click);
            // 
            // VersionLbl
            // 
            this.VersionLbl.AutoSize = true;
            this.VersionLbl.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.VersionLbl.ForeColor = System.Drawing.Color.Silver;
            this.VersionLbl.Location = new System.Drawing.Point(21, 419);
            this.VersionLbl.Name = "VersionLbl";
            this.VersionLbl.Size = new System.Drawing.Size(62, 19);
            this.VersionLbl.TabIndex = 0;
            this.VersionLbl.Text = "Version ";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(20, 125);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(109, 19);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Serial Terminal";
            // 
            // Panel_AboutThinButton
            // 
            this.Panel_AboutThinButton.ActiveBorderThickness = 1;
            this.Panel_AboutThinButton.ActiveCornerRadius = 5;
            this.Panel_AboutThinButton.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Panel_AboutThinButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.Panel_AboutThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(195)))), ((int)(((byte)(175)))));
            this.Panel_AboutThinButton.BackColor = System.Drawing.Color.Transparent;
            this.Panel_AboutThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_AboutThinButton.BackgroundImage")));
            this.Panel_AboutThinButton.ButtonText = "About";
            this.Panel_AboutThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_AboutThinButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_AboutThinButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.Panel_AboutThinButton.IdleBorderThickness = 1;
            this.Panel_AboutThinButton.IdleCornerRadius = 5;
            this.Panel_AboutThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.Panel_AboutThinButton.IdleForecolor = System.Drawing.Color.DimGray;
            this.Panel_AboutThinButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.Panel_AboutThinButton.Location = new System.Drawing.Point(14, 279);
            this.Panel_AboutThinButton.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_AboutThinButton.Name = "Panel_AboutThinButton";
            this.Panel_AboutThinButton.Size = new System.Drawing.Size(120, 40);
            this.Panel_AboutThinButton.TabIndex = 3;
            this.Panel_AboutThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Panel_AboutThinButton.Click += new System.EventHandler(this.Panel_AboutThinButton_Click);
            // 
            // Panel_Logo
            // 
            this.Panel_Logo.BackColor = System.Drawing.Color.Transparent;
            this.Panel_Logo.Image = global::Terminal.Properties.Resources.Connector_4;
            this.Panel_Logo.InitialImage = global::Terminal.Properties.Resources.Connector_4;
            this.Panel_Logo.Location = new System.Drawing.Point(24, 21);
            this.Panel_Logo.Name = "Panel_Logo";
            this.Panel_Logo.Size = new System.Drawing.Size(100, 102);
            this.Panel_Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Panel_Logo.TabIndex = 2;
            this.Panel_Logo.TabStop = false;
            // 
            // Panel_HelpThinButton
            // 
            this.Panel_HelpThinButton.ActiveBorderThickness = 1;
            this.Panel_HelpThinButton.ActiveCornerRadius = 5;
            this.Panel_HelpThinButton.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Panel_HelpThinButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.Panel_HelpThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.Panel_HelpThinButton.BackColor = System.Drawing.Color.Transparent;
            this.Panel_HelpThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_HelpThinButton.BackgroundImage")));
            this.Panel_HelpThinButton.ButtonText = "Help";
            this.Panel_HelpThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_HelpThinButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_HelpThinButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.Panel_HelpThinButton.IdleBorderThickness = 1;
            this.Panel_HelpThinButton.IdleCornerRadius = 5;
            this.Panel_HelpThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.Panel_HelpThinButton.IdleForecolor = System.Drawing.Color.DimGray;
            this.Panel_HelpThinButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.Panel_HelpThinButton.Location = new System.Drawing.Point(14, 221);
            this.Panel_HelpThinButton.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_HelpThinButton.Name = "Panel_HelpThinButton";
            this.Panel_HelpThinButton.Size = new System.Drawing.Size(120, 40);
            this.Panel_HelpThinButton.TabIndex = 2;
            this.Panel_HelpThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Panel_HelpThinButton.Click += new System.EventHandler(this.Panel_HelpThinButton_Click);
            // 
            // Panel_ExitThinButton
            // 
            this.Panel_ExitThinButton.ActiveBorderThickness = 1;
            this.Panel_ExitThinButton.ActiveCornerRadius = 5;
            this.Panel_ExitThinButton.ActiveFillColor = System.Drawing.Color.Transparent;
            this.Panel_ExitThinButton.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.Panel_ExitThinButton.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(98)))), ((int)(((byte)(95)))));
            this.Panel_ExitThinButton.BackColor = System.Drawing.Color.Transparent;
            this.Panel_ExitThinButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Panel_ExitThinButton.BackgroundImage")));
            this.Panel_ExitThinButton.ButtonText = "Exit";
            this.Panel_ExitThinButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Panel_ExitThinButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel_ExitThinButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.Panel_ExitThinButton.IdleBorderThickness = 1;
            this.Panel_ExitThinButton.IdleCornerRadius = 5;
            this.Panel_ExitThinButton.IdleFillColor = System.Drawing.Color.Transparent;
            this.Panel_ExitThinButton.IdleForecolor = System.Drawing.Color.DimGray;
            this.Panel_ExitThinButton.IdleLineColor = System.Drawing.Color.DimGray;
            this.Panel_ExitThinButton.Location = new System.Drawing.Point(14, 337);
            this.Panel_ExitThinButton.Margin = new System.Windows.Forms.Padding(5);
            this.Panel_ExitThinButton.Name = "Panel_ExitThinButton";
            this.Panel_ExitThinButton.Size = new System.Drawing.Size(120, 40);
            this.Panel_ExitThinButton.TabIndex = 4;
            this.Panel_ExitThinButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Panel_ExitThinButton.Click += new System.EventHandler(this.Panel_ExitThinButton_Click);
            // 
            // DataSend_SendFileBtn
            // 
            this.DataSend_SendFileBtn.ActiveBorderThickness = 1;
            this.DataSend_SendFileBtn.ActiveCornerRadius = 5;
            this.DataSend_SendFileBtn.ActiveFillColor = System.Drawing.Color.Transparent;
            this.DataSend_SendFileBtn.ActiveForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.DataSend_SendFileBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(134)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.DataSend_SendFileBtn.BackColor = System.Drawing.Color.White;
            this.DataSend_SendFileBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DataSend_SendFileBtn.BackgroundImage")));
            this.DataSend_SendFileBtn.ButtonText = "Send File";
            this.DataSend_SendFileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DataSend_SendFileBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DataSend_SendFileBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DataSend_SendFileBtn.IdleBorderThickness = 1;
            this.DataSend_SendFileBtn.IdleCornerRadius = 5;
            this.DataSend_SendFileBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.DataSend_SendFileBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.DataSend_SendFileBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(126)))), ((int)(((byte)(229)))));
            this.DataSend_SendFileBtn.Location = new System.Drawing.Point(774, 328);
            this.DataSend_SendFileBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DataSend_SendFileBtn.Name = "DataSend_SendFileBtn";
            this.DataSend_SendFileBtn.Size = new System.Drawing.Size(77, 31);
            this.DataSend_SendFileBtn.TabIndex = 36;
            this.DataSend_SendFileBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DataSend_SendFileBtn.Click += new System.EventHandler(this.DataSend_SendFileBtn_Click);
            // 
            // IncrementFontSizeBtn
            // 
            this.IncrementFontSizeBtn.ActiveBorderThickness = 1;
            this.IncrementFontSizeBtn.ActiveCornerRadius = 5;
            this.IncrementFontSizeBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.IncrementFontSizeBtn.ActiveForecolor = System.Drawing.Color.White;
            this.IncrementFontSizeBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.IncrementFontSizeBtn.BackColor = System.Drawing.Color.White;
            this.IncrementFontSizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("IncrementFontSizeBtn.BackgroundImage")));
            this.IncrementFontSizeBtn.ButtonText = "+";
            this.IncrementFontSizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.IncrementFontSizeBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.IncrementFontSizeBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.IncrementFontSizeBtn.IdleBorderThickness = 1;
            this.IncrementFontSizeBtn.IdleCornerRadius = 5;
            this.IncrementFontSizeBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.IncrementFontSizeBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.IncrementFontSizeBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.IncrementFontSizeBtn.Location = new System.Drawing.Point(478, 157);
            this.IncrementFontSizeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.IncrementFontSizeBtn.Name = "IncrementFontSizeBtn";
            this.IncrementFontSizeBtn.Size = new System.Drawing.Size(30, 30);
            this.IncrementFontSizeBtn.TabIndex = 37;
            this.IncrementFontSizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.IncrementFontSizeBtn.Click += new System.EventHandler(this.IncrementFontSizeBtn_Click);
            // 
            // DecrementFontSizeBtn
            // 
            this.DecrementFontSizeBtn.ActiveBorderThickness = 1;
            this.DecrementFontSizeBtn.ActiveCornerRadius = 5;
            this.DecrementFontSizeBtn.ActiveFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.DecrementFontSizeBtn.ActiveForecolor = System.Drawing.Color.White;
            this.DecrementFontSizeBtn.ActiveLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.DecrementFontSizeBtn.BackColor = System.Drawing.Color.White;
            this.DecrementFontSizeBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DecrementFontSizeBtn.BackgroundImage")));
            this.DecrementFontSizeBtn.ButtonText = "-";
            this.DecrementFontSizeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DecrementFontSizeBtn.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.DecrementFontSizeBtn.ForeColor = System.Drawing.Color.SeaGreen;
            this.DecrementFontSizeBtn.IdleBorderThickness = 1;
            this.DecrementFontSizeBtn.IdleCornerRadius = 5;
            this.DecrementFontSizeBtn.IdleFillColor = System.Drawing.Color.Transparent;
            this.DecrementFontSizeBtn.IdleForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.DecrementFontSizeBtn.IdleLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(227)))), ((int)(((byte)(97)))), ((int)(((byte)(99)))));
            this.DecrementFontSizeBtn.Location = new System.Drawing.Point(518, 157);
            this.DecrementFontSizeBtn.Margin = new System.Windows.Forms.Padding(5);
            this.DecrementFontSizeBtn.Name = "DecrementFontSizeBtn";
            this.DecrementFontSizeBtn.Size = new System.Drawing.Size(30, 30);
            this.DecrementFontSizeBtn.TabIndex = 38;
            this.DecrementFontSizeBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DecrementFontSizeBtn.Click += new System.EventHandler(this.DecrementFontSizeBtn_Click);
            // 
            // FontSizeLbl
            // 
            this.FontSizeLbl.AutoSize = true;
            this.FontSizeLbl.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.FontSizeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(194)))), ((int)(((byte)(255)))));
            this.FontSizeLbl.Location = new System.Drawing.Point(335, 162);
            this.FontSizeLbl.Name = "FontSizeLbl";
            this.FontSizeLbl.Size = new System.Drawing.Size(108, 20);
            this.FontSizeLbl.TabIndex = 39;
            this.FontSizeLbl.Text = "Font Size : 8pt";
            // 
            // MainForm
            // 
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.FontSizeLbl);
            this.Controls.Add(this.DecrementFontSizeBtn);
            this.Controls.Add(this.IncrementFontSizeBtn);
            this.Controls.Add(this.DataSend_SendFileBtn);
            this.Controls.Add(this.MinimizePicBox);
            this.Controls.Add(this.ClosePicBox);
            this.Controls.Add(this.SerialPort_DtrCheckBox);
            this.Controls.Add(this.SerialPort_RtsCheckBox);
            this.Controls.Add(this.SerialPort_RtsLbl);
            this.Controls.Add(this.SerialPort_DtrLbl);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.SendWithLFCheckBox);
            this.Controls.Add(this.SendWithCRCheckBox);
            this.Controls.Add(this.SerialPort_ReceivedDataTxtBox);
            this.Controls.Add(this.SerialPort_SendDataTxtBox);
            this.Controls.Add(this.DataSend_ClearBtn);
            this.Controls.Add(this.ComPort_GroupBox);
            this.Controls.Add(this.BaudRate_GroupBox);
            this.Controls.Add(this.DataSend_SendBtn);
            this.Controls.Add(this.DataSend_ExportBtn);
            this.Controls.Add(this.DataReceived_ExportBtn);
            this.Controls.Add(this.DataReceived_ClearBtn);
            this.Controls.Add(this.StopBit_GroupBox);
            this.Controls.Add(this.Parity_GroupBox);
            this.Controls.Add(this.DataBit_GroupBox);
            this.Controls.Add(this.ControlPanel);
            this.Controls.Add(this.SerialPort_SendDataListBox);
            this.Controls.Add(this.SendWithCRLbl);
            this.Controls.Add(this.SendWithLFLbl);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainForm_Paint);
            this.DataBit_GroupBox.ResumeLayout(false);
            this.DataBit_GroupBox.PerformLayout();
            this.Parity_GroupBox.ResumeLayout(false);
            this.Parity_GroupBox.PerformLayout();
            this.StopBit_GroupBox.ResumeLayout(false);
            this.StopBit_GroupBox.PerformLayout();
            this.BaudRate_GroupBox.ResumeLayout(false);
            this.BaudRate_GroupBox.PerformLayout();
            this.ComPort_GroupBox.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MinimizePicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClosePicBox)).EndInit();
            this.ControlPanel.ResumeLayout(false);
            this.ControlPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Panel_Logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse MainForm_Elipse;
        private Bunifu.Framework.UI.BunifuGradientPanel ControlPanel;
        private Bunifu.Framework.UI.BunifuThinButton2 Panel_AboutThinButton;
        private System.Windows.Forms.PictureBox Panel_Logo;
        private Bunifu.Framework.UI.BunifuThinButton2 Panel_HelpThinButton;
        private Bunifu.Framework.UI.BunifuThinButton2 Panel_ExitThinButton;
        private Bunifu.Framework.UI.BunifuDragControl MainForm_DragControl;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuFlatButton ComPort_ScanBtn;
        private Bunifu.Framework.UI.BunifuFlatButton ComPort_ConnectBtn;
        private System.Windows.Forms.GroupBox StopBit_GroupBox;
        private System.Windows.Forms.RadioButton StopBit_2RadioButton;
        private System.Windows.Forms.RadioButton StopBit_1RadioButton;
        private Bunifu.Framework.UI.BunifuSeparator StopBit_Separator;
        private System.Windows.Forms.GroupBox Parity_GroupBox;
        private System.Windows.Forms.RadioButton Parity_NonRadioButton;
        private System.Windows.Forms.RadioButton Parity_OddRadioButton;
        private System.Windows.Forms.RadioButton Parity_EvenRadioButton;
        private System.Windows.Forms.RadioButton Parity_MarkRadioButton;
        private System.Windows.Forms.RadioButton Parity_SpaceRadioButton;
        private Bunifu.Framework.UI.BunifuSeparator Parity_Separator;
        private System.Windows.Forms.GroupBox DataBit_GroupBox;
        private System.Windows.Forms.RadioButton DataBit_8RadioButton;
        private System.Windows.Forms.RadioButton DataBit_7RadioButton;
        private System.Windows.Forms.RadioButton DataBit_6RadioButton;
        private System.Windows.Forms.RadioButton DataBit_5RadioButton;
        private Bunifu.Framework.UI.BunifuSeparator DataBit_Separator;
        public System.IO.Ports.SerialPort SerialPort_Connection;
        private Bunifu.Framework.UI.BunifuFlatButton DataSend_ExportBtn;
        private Bunifu.Framework.UI.BunifuFlatButton DataReceived_ExportBtn;
        private Bunifu.Framework.UI.BunifuFlatButton DataReceived_ClearBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 DataSend_SendBtn;
        private System.Windows.Forms.GroupBox BaudRate_GroupBox;
        private System.Windows.Forms.RadioButton BaudRate_14400RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_19200RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_28800RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_38400RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_56000RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_600RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_1200RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_2400RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_4800RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_9600RadioButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator1;
        private System.Windows.Forms.RadioButton BaudRate_57600RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_115200RadioButton;
        private System.Windows.Forms.GroupBox ComPort_GroupBox;
        private System.Windows.Forms.ComboBox ComPort_ComboBox;
        private Bunifu.Framework.UI.BunifuFlatButton DataSend_ClearBtn;
        private System.Windows.Forms.ListBox SerialPort_SendDataListBox;
        private Bunifu.Framework.UI.BunifuMaterialTextbox SerialPort_SendDataTxtBox;
        private System.Windows.Forms.RichTextBox SerialPort_ReceivedDataTxtBox;
        private Bunifu.Framework.UI.BunifuCheckbox SendWithCRCheckBox;
        private Bunifu.Framework.UI.BunifuCheckbox SendWithLFCheckBox;
        private Bunifu.Framework.UI.BunifuCustomLabel SendWithCRLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel SendWithLFLbl;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Handshake_RTS_CTS_XOnXOffRadioButton;
        private System.Windows.Forms.RadioButton Handshake_RTS_CTSRadioButton;
        private System.Windows.Forms.RadioButton Handshake_XOnXOffRadioButton;
        private System.Windows.Forms.RadioButton Handshake_NonRadioButton;
        private Bunifu.Framework.UI.BunifuSeparator bunifuSeparator2;
        private Bunifu.Framework.UI.BunifuCheckbox SerialPort_DtrCheckBox;
        private Bunifu.Framework.UI.BunifuCheckbox SerialPort_RtsCheckBox;
        private Bunifu.Framework.UI.BunifuCustomLabel SerialPort_RtsLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel SerialPort_DtrLbl;
        private Bunifu.Framework.UI.BunifuCustomLabel VersionLbl;
        private Bunifu.Framework.UI.BunifuThinButton2 Panel_AsciiThinButton;
        private System.Windows.Forms.PictureBox ClosePicBox;
        private System.Windows.Forms.PictureBox MinimizePicBox;
        private System.Windows.Forms.RadioButton BaudRate_128000RadioButton;
        private System.Windows.Forms.RadioButton BaudRate_256000RadioButton;
        private Bunifu.Framework.UI.BunifuThinButton2 DataSend_SendFileBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel FontSizeLbl;
        private Bunifu.Framework.UI.BunifuThinButton2 DecrementFontSizeBtn;
        private Bunifu.Framework.UI.BunifuThinButton2 IncrementFontSizeBtn;
    }
}