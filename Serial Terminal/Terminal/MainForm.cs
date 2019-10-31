using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class MainForm : Form
    {

        UInt16 font_size = 8;

        public MainForm()
        {

            InitializeComponent();

            VersionLbl.Text += "1.0.0.1";

            ComPort_ScanBtn_Click(new object() , new EventArgs()); /* Call method */

        }

        private void MainForm_Paint(object sender, PaintEventArgs e)
        {

            Graphics graph; /* Create object */

            graph = this.CreateGraphics();
            
            Pen myPen = new Pen(Color.FromArgb(0, 195, 175));
            myPen.Width = 4;
            graph.DrawLine(myPen, 150, 10, 150, 440);

            myPen.Width = 0.5f;
            graph.DrawRectangle(myPen, 0, 0, 948, 448);

            myPen = new Pen(Color.FromArgb(220,220,220));
            myPen.Width = 1;
            graph.DrawLine(myPen, 164, 154, 938, 154);

            myPen = new Pen(Color.FromArgb(70, 194, 255)); /* Color for rectangle */
            graph.DrawRectangle(myPen, 164, 189, 773, 130);

        }

        private void Panel_AsciiThinButton_Click(object sender, EventArgs e)
        {
            AsciiTableForm.ShowAsciiTable(); /* Show table */
        }

        private void Panel_HelpThinButton_Click(object sender, EventArgs e)
        {
            HelpForm.ShowHelpMessage(); /* Show message */
        }

        private void Panel_AboutThinButton_Click(object sender, EventArgs e)
        {
            AboutForm.ShowAboutMessage(); /* Show about message */
        }

        private void Panel_ExitThinButton_Click(object sender, EventArgs e)
        {

            if (ComPort_ConnectBtn.Text == "Disconnect") /* Check key status */
            {

                SerialPort_Connection.Close(); /* Close port */

                /* ----------------------------------- */

                ComPort_ScanBtn.Enabled = true; /* Enable scan btn */
                ComPort_ComboBox.Enabled = true; /* Enable combobox */

                /* ----------------------------------- */

                ComPort_ConnectBtn.Activecolor = Color.FromArgb(0, 195, 175); /* Set color */
                ComPort_ConnectBtn.Normalcolor = Color.FromArgb(0, 195, 175); /* Set color */
                ComPort_ConnectBtn.OnHovercolor = Color.FromArgb(0, 175, 175); /* Set color */
                ComPort_ConnectBtn.Text = "Connect"; /* Change button text */

            }

            ExitForm.ShowExitMessage(); /* Show exit message */

        }

        private void MinimizePicBox_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized; /* Minimize application */
        }

        /* ---------------------------- Set Font ---------------------------- */
        private void IncrementFontSizeBtn_Click(object sender, EventArgs e)
        {

            if (font_size < 20) /* Check status */
            {
                font_size += 1; /* Increment value */
            }

            /* ----------------------- */

            SerialPort_ReceivedDataTxtBox.Font = new Font("Segoe UI", font_size, FontStyle.Regular); /* Set font size */
            SerialPort_SendDataListBox.Font = new Font("Segoe UI", font_size, FontStyle.Regular); /* Set font size */

            FontSizeLbl.Text = "Font Size : " + font_size.ToString("#.#") + "pt"; /* Show value */

        }

        private void DecrementFontSizeBtn_Click(object sender, EventArgs e)
        {

            if (font_size > 5) /* Check status */
            {
                font_size -= 1; /* Increment value */
            }

            /* ----------------------- */

            SerialPort_ReceivedDataTxtBox.Font = new Font("Segoe UI", font_size, FontStyle.Regular); /* Set font size */
            SerialPort_SendDataListBox.Font = new Font("Segoe UI", font_size, FontStyle.Regular); /* Set font size */

            FontSizeLbl.Text = "Font Size : " + font_size.ToString("#.#") + "pt"; /* Show value */

        }

        /* ----------------------------------------------------------------------------- */

        private void ComPort_ScanBtn_Click(object sender, EventArgs e)
        {

            /* -------------------- Create variable -------------------- */

            string[] com_ports; /* Create array for get port names */

            /* --------------------------------------------------------- */

            com_ports = SerialPort.GetPortNames(); /* Get ports name */
            ComPort_ComboBox.Items.Clear(); /* Clear previos port names */
            ComPort_ComboBox.Items.AddRange(com_ports); /* Add new port names */
            ComPort_ComboBox.SelectedIndex = 0; /* Select first port */

        }

        private void ComPort_ConnectBtn_Click(object sender, EventArgs e)
        {

            if ( ComPort_ComboBox.SelectedItem != null) /* Check COM Port */
            {

                if (ComPort_ConnectBtn.Text == "Connect") /* Check key status */
                {

                    ComPort_ScanBtn.Enabled = false; /* Disable scan btn */

                    /* ----------------------------------- */

                    SerialPort_Connection.PortName = ComPort_ComboBox.SelectedItem.ToString(); /* Get port name */

                    try
                    {
                        SerialPort_Connection.Open(); /* open port for connect */

                        /* ----------------------------------- */

                        ComPort_ComboBox.Enabled = false; /* Disable combobox */

                        /* ----------------------------------- */

                        ComPort_ConnectBtn.Activecolor = Color.FromArgb(255, 195, 75); /* Set color */
                        ComPort_ConnectBtn.Normalcolor = Color.FromArgb(255, 195, 75); /* Set color */
                        ComPort_ConnectBtn.OnHovercolor = Color.FromArgb(255, 175, 75); /* Set color */
                        ComPort_ConnectBtn.Text = "Disconnect"; /* Change button text */

                    }
                    catch (Exception error)
                    {

                        MessageBox.Show(error.Message); /* Show error message */
                        SerialPort_Connection.Close(); /* Close port */
                        ComPort_ComboBox.Focus(); /* Focus on combobox */

                        ComPort_ScanBtn.Enabled = true; /* Enable scan btn */

                        /* ----------------------------------- */

                        SerialPort_Connection.Close(); /* Close port */

                        /* ----------------------------------- */

                        ComPort_ComboBox.Enabled = true; /* Enable combobox */

                        /* ----------------------------------- */

                        ComPort_ConnectBtn.Activecolor = Color.FromArgb(0, 195, 175); /* Set color */
                        ComPort_ConnectBtn.Normalcolor = Color.FromArgb(0, 195, 175); /* Set color */
                        ComPort_ConnectBtn.OnHovercolor = Color.FromArgb(0, 175, 175); /* Set color */
                        ComPort_ConnectBtn.Text = "Connect"; /* Change button text */

                    }

                }

                else if (ComPort_ConnectBtn.Text == "Disconnect") /* Check key status */
                {

                    ComPort_ScanBtn.Enabled = true; /* Enable scan btn */

                    /* ----------------------------------- */

                    SerialPort_Connection.Close(); /* Close port */

                    /* ----------------------------------- */

                    ComPort_ComboBox.Enabled = true; /* Enable combobox */

                    /* ----------------------------------- */

                    ComPort_ConnectBtn.Activecolor = Color.FromArgb(0, 195, 175); /* Set color */
                    ComPort_ConnectBtn.Normalcolor = Color.FromArgb(0, 195, 175); /* Set color */
                    ComPort_ConnectBtn.OnHovercolor = Color.FromArgb(0, 175, 175); /* Set color */
                    ComPort_ConnectBtn.Text = "Connect"; /* Change button text */

                }

                else /* Needed */
                {
                    /* Non instruction */
                }

            }
            else
            {
                CustomForm.ShowCustomMessage(Color.White,Properties.Resources.Select,"Please Select COM Port"); /* Show message */
            }
            
            /* Function end */
        }

        /* ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ */

        private void DataReceived_ClearBtn_Click(object sender, EventArgs e)
        {
            SerialPort_ReceivedDataTxtBox.Text = ""; /* Clear Received message text box */
        }

        private void DataReceived_ExportBtn_Click(object sender, EventArgs e)
        {

            /* --------------------- Create Object --------------------- */

            SaveFileDialog file_info = new SaveFileDialog(); /* Create object for get directory addres - "folderaddresopen" is the name of object */

            /* --------------------- Object config --------------------- */

            file_info.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; /* Set format filter */
            file_info.FilterIndex = 1; /* Select first index */
            file_info.RestoreDirectory = true; /* Change directory to the previously location before close */

            /* --------------------------------------------------------- */

            if (file_info.ShowDialog() == DialogResult.OK) /* Check status */
            {

                /* --------------------- Create Object --------------------- */

                TextWriter file = new StreamWriter(file_info.OpenFile()); /* Object for create and write in txt file */

                /* --------------------------------------------------------- */

                file.Write(SerialPort_ReceivedDataTxtBox.Text);
                /*file.WriteLine(SerialPort_ReceivedDataTxtBox.Text); /* Write items to txt file */

                file.Close(); /* Close the TextWriter Object(file) */

                /* ---------------------------------------- */

                CustomForm.ShowCustomMessage(Color.FromArgb(247,247,247),Properties.Resources.Ok_1,"Exported"); /* Show message */

            }
            else
            {
                CancelForm.ShowCanceledMessage(); /* Show message */
            }

            /* Function end */
        }

        /* ^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^ */

        private void SerialPort_SendDataListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                SerialPort_SendDataTxtBox.Text = SerialPort_SendDataListBox.SelectedItem.ToString(); /* Copy value from selected item */
                SerialPort_SendDataListBox.SelectionMode = SelectionMode.None; /* Change mode */
                SerialPort_SendDataListBox.SelectionMode = SelectionMode.One; /* Change mode */
            }
            catch (Exception)
            {

            }

        }

        private void SerialPort_SendDataTxtBox_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter) /* Check selected key */
            {
                DataSend_SendBtn_Click(sender, e); /* Send Data */
            }

        }

        private void DataSend_ClearBtn_Click(object sender, EventArgs e)
        {
            SerialPort_SendDataListBox.Items.Clear(); /* Clear message sent list box */
        }

        private void DataSend_SendFileBtn_Click(object sender, EventArgs e)
        {

            /* --------------------- Create Object --------------------- */

            OpenFileDialog text_file = new OpenFileDialog(); /* Object for select text file */

            /* --------------------- Set Object --------------------- */

            text_file.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; /* Set format filter */
            text_file.FilterIndex = 1; /* Select first index */
            text_file.RestoreDirectory = true; /* Change directory to the previously location before close */

            /* --------------------- Create variable --------------------- */

            string file_data;

            /* ------------------------------------------------------------------------------------------- */

            if (ComPort_ConnectBtn.Text == "Disconnect") /* Check key status */
            {

                if (text_file.ShowDialog() == DialogResult.OK) /* Check status */
                {

                    TextReader file = new StreamReader(text_file.OpenFile()); /* Object for read txt file */

                    /* --------------------------------------------------------- */

                    for (int number_of_line = 0; number_of_line < File.ReadAllLines(text_file.FileName).Length; number_of_line++) /* Loop for write data */
                    {



                        /* ------------------- Read value from text file ------------------- */

                        file_data = file.ReadLine(); /* Read value from text file */

                        /* ------------------- Show value in list box ------------------- */

                        SerialPort_SendDataListBox.Items.Add(file_data); /* Add value to list box */

                        /* ------------------- Send data to serial ------------------- */

                        if (SendWithCRCheckBox.Checked == true) /* Check status */
                        {
                            file_data += "\r";
                        }
                        if (SendWithLFCheckBox.Checked == true) /* Check status */
                        {
                            file_data += "\n";
                        }

                        SerialPort_Connection.Write(file_data); /* Send data */

                    }

                    /* --------------------------------------------------------- */

                    file.Close(); /* Close the TextReader Object(file) */

                }

            }
            else
            {
                CustomForm.ShowCustomMessage(Color.White, Properties.Resources.Select, "Please Connect to Port"); /* Show message */
            }

        }

        private void DataSend_SendBtn_Click(object sender, EventArgs e)
        {

            string data;

            if (ComPort_ConnectBtn.Text == "Disconnect") /* Check key status */
            {

                /* ------------------- Option ------------------- */

                DataSend_SendBtn.Visible = false; /* Disable button */

                /* ------------------- Send data to serial ------------------- */
                data = SerialPort_SendDataTxtBox.Text;

                if (SendWithCRCheckBox.Checked == true)
                {
                    data += "\r";
                }
                if (SendWithLFCheckBox.Checked == true)
                {
                    data += "\n";
                }

                try
                {
                    SerialPort_Connection.Write(data); /* Send data to serial port */
                }
                catch (Exception)
                {

                    throw;
                }

                SerialPort_SendDataListBox.Items.Add(SerialPort_SendDataTxtBox.Text); /* Show message sent in list box */
                SerialPort_SendDataTxtBox.Text = string.Empty; /* Clear text box */
                SerialPort_SendDataTxtBox.Focus(); /* Focus on textbox */

                /* ------------------- Receive data from serial ------------------- */

                SerialPort_Connection.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler); /* Event for controll received data */

                /* ------------------- Option ------------------- */

                DataSend_SendBtn.Visible = true; /* Enable button */

            }
            else
            {
                CustomForm.ShowCustomMessage(Color.White,Properties.Resources.Select,"Please Connect to Port"); /* Show message */
            }

            /* Function end */
        }

        private void DataSend_ExportBtn_Click(object sender, EventArgs e)
        {
            /* --------------------- Create Variable --------------------- */

            Int32 item_counter = SerialPort_SendDataListBox.Items.Count; /* Variable for count items */

            /* --------------------- Create Object --------------------- */

            SaveFileDialog file_info = new SaveFileDialog(); /* Create object for get directory addres - "folderaddresopen" is the name of object */

            /* --------------------- Object config --------------------- */

            file_info.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; /* Set format filter */
            file_info.FilterIndex = 1; /* Select first index */
            file_info.RestoreDirectory = true; /* Change directory to the previously location before close */

            /* --------------------------------------------------------- */

            if (file_info.ShowDialog() == DialogResult.OK) /* Check status */
            {

                /* --------------------- Create Object --------------------- */

                TextWriter file = new StreamWriter(file_info.OpenFile()); /* Object for create and write in txt file */

                /* --------------------------------------------------------- */

                for (int i = 0; i < item_counter; i++) /* Loop for write to txt file */
                {
                    file.WriteLine(SerialPort_SendDataListBox.Items[i].ToString()); /* Write items to txt file */
                }

                file.Close(); /* Close the TextWriter Object(file) */

                /* ---------------------------------------- */

                CustomForm.ShowCustomMessage(Color.FromArgb(247,247,247),Properties.Resources.Ok_1,"Exported"); /* Show message */

            }
            else
            {
                CancelForm.ShowCanceledMessage(); /* Show message */
            }

            /* Function end */
        }

        /* ---------------------------- Change Serial Config ---------------------------- */

        private void DataBit_Changed(object sender, EventArgs e)
        {

            if (DataBit_5RadioButton.Checked == true) /* Check status */
            {

                StopBit_2RadioButton.Enabled = false; /* Disable button */
                SerialPort_Connection.DataBits = 5; /* Set data bits */

            }
            else if (DataBit_6RadioButton.Checked == true) /* Check status */
            {

                StopBit_2RadioButton.Enabled = true; /* Enable button */
                SerialPort_Connection.DataBits = 6; /* Set data bits */

            }
            else if (DataBit_7RadioButton.Checked == true) /* Check status */
            {

                StopBit_2RadioButton.Enabled = true; /* Enable button */
                SerialPort_Connection.DataBits = 7; /* Set data bits */

            }
            else if (DataBit_8RadioButton.Checked == true) /* Check status */
            {

                StopBit_2RadioButton.Enabled = true; /* Enable button */
                SerialPort_Connection.DataBits = 8; /* Set data bits */

            }
            else
            {
                /* No instruction */
            }

        }

        private void Parity_Changed(object sender, EventArgs e)
        {

            if (Parity_NonRadioButton.Checked == true) /* Check status */
            {
                SerialPort_Connection.Parity = Parity.None; /* Set parity */
            }
            else if (Parity_OddRadioButton.Checked == true) /* Check status */
            {
                SerialPort_Connection.Parity = Parity.Odd; /* Set parity */
            }
            else if (Parity_EvenRadioButton.Checked == true) /* Check status */
            {
                SerialPort_Connection.Parity = Parity.Even; /* Set parity */
            }
            else if (Parity_MarkRadioButton.Checked == true) /* Check status */
            {
                SerialPort_Connection.Parity = Parity.Mark; /* Set parity */
            }
            else if (Parity_SpaceRadioButton.Checked == true) /* Check status */
            {
                SerialPort_Connection.Parity = Parity.Space; /* Set parity */
            }
            else
            {
                /* No instruction */
            }

        }

        private void StopBit_Changed(object sender, EventArgs e)
        {

            if (StopBit_1RadioButton.Checked == true) /* Check status */
            {

                DataBit_5RadioButton.Enabled = true; /* Enable botton */
                SerialPort_Connection.StopBits = StopBits.One; /* Set stop bit */

            }
            else if (StopBit_2RadioButton.Checked == true) /* Check status */
            {

                DataBit_5RadioButton.Enabled = false; /* Disable botton */
                SerialPort_Connection.StopBits = StopBits.Two; /* Set stop bit */

            }
            else
            {
                /* No instruction */
            }

        }

        private void BaudRate_Changed(object sender, EventArgs e)
        {

            try
            {

                if (BaudRate_600RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 600; /* Set baud rate */
                }
                else if (BaudRate_1200RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 1200; /* Set baud rate */
                }
                else if (BaudRate_2400RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 2400; /* Set baud rate */
                }
                else if (BaudRate_4800RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 4800; /* Set baud rate */
                }
                else if (BaudRate_9600RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 9600; /* Set baud rate */
                }
                else if (BaudRate_14400RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 14400; /* Set baud rate */
                }
                else if (BaudRate_19200RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 19200; /* Set baud rate */
                }
                else if (BaudRate_28800RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 28800; /* Set baud rate */
                }
                else if (BaudRate_38400RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 38400; /* Set baud rate */
                }
                else if (BaudRate_56000RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 56000; /* Set baud rate */
                }
                else if (BaudRate_57600RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 57600; /* Set baud rate */
                }
                else if (BaudRate_115200RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 115200; /* Set baud rate */
                }
                else if (BaudRate_128000RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 128000; /* Set baud rate */
                }
                else if (BaudRate_256000RadioButton.Checked == true) /* Check status */
                {
                    SerialPort_Connection.BaudRate = 256000; /* Set baud rate */
                }
                else
                {
                    /* No instruction */
                }

            }
            catch (Exception)
            {
                
                CustomForm.ShowCustomMessage(Color.White , Properties.Resources.Loading_15 , "Baud rate is not available for this port"); /* Show message */
                BaudRate_9600RadioButton.Checked = true; /* Select button */
                SerialPort_Connection.BaudRate = 9600; /* Set baud rate */

            }

        }

        private void Handshake_Changed(object sender, EventArgs e)
        {

            if (Handshake_NonRadioButton.Checked == true) /* Check status */
            {

                SerialPort_RtsCheckBox.Enabled = true; /* Enable checkbox */
                SerialPort_Connection.Handshake = Handshake.None; /* Set handshake */

            }
            else if (Handshake_XOnXOffRadioButton.Checked == true) /* Check status */
            {

                SerialPort_RtsCheckBox.Enabled = true; /* Enable checkbox */
                SerialPort_Connection.Handshake = Handshake.XOnXOff; /* Set handshake */

            }
            else if (Handshake_RTS_CTSRadioButton.Checked == true) /* Check status */
            {

                SerialPort_RtsCheckBox.Enabled = false; /* Disable checkbox */
                SerialPort_Connection.Handshake = Handshake.RequestToSend; /* Set handshake */

            }
            else if (Handshake_RTS_CTS_XOnXOffRadioButton.Checked == true) /* Check status */
            {

                SerialPort_RtsCheckBox.Enabled = false; /* Disable checkbox */
                SerialPort_Connection.Handshake = Handshake.RequestToSendXOnXOff; /* Set handshake */

            }
            else
            {
                /* No instruction */
            }

        }

        private void SerialPort_RtsCheckBox_OnChange(object sender, EventArgs e)
        {

            if (SerialPort_RtsCheckBox.Checked == true) /* Check status */
            {
                SerialPort_Connection.RtsEnable = true; /* Enable RTS */
            }
            else
            {
                SerialPort_Connection.RtsEnable = false; /* Disable RTS */
            }

        }

        private void SerialPort_DtrCheckBox_OnChange(object sender, EventArgs e)
        {

            if (SerialPort_DtrCheckBox.Checked == true) /* Check status */
            {
                SerialPort_Connection.DtrEnable = true; /* Enable DTR */
            }
            else
            {
                SerialPort_Connection.DtrEnable = false; /* Disable DTR */
            }

        }

        /* ---------------------------- Receive From Serial ---------------------------- */

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender; /* Create object */
            string indata = sp.ReadExisting(); /* Read value */

            /* ----------------------------------- */

            SerialPort_ReceivedDataTxtBox_Add(new object(), new EventArgs(), indata); /* Add value in tect box */
        }

        private void SerialPort_ReceivedDataTxtBox_Add(object sender, EventArgs e,string str)
        {
            this.Invoke(new MethodInvoker(delegate ()
            {
                SerialPort_ReceivedDataTxtBox.Text += str;
            })); /* Add data to text box */
        }

    }

}
