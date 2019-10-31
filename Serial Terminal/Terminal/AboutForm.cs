using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class AboutForm : Form
    {
        public AboutForm()
        {
            InitializeComponent();
        }

        private void AboutForm_InstagramIdLbl_Click(object sender, EventArgs e)
        {
            Process.Start("https://instagram.com/majid.derhambakhsh"); /* Show website */
        }

        private void AboutForm_TelegramIdLbl_Click(object sender, EventArgs e)
        {
            Process.Start("https://t.me/MajidDerhambakhsh"); /* Show website */
        }

        private void AboutForm_EmailAddressLbl_Click(object sender, EventArgs e)
        {
            Process.Start("mailto: majid.do16@gmail.com" + "?subject= Serial Terminal Support"); /* Send mail */
        }

        private void AboutForm_OkThinButton_Click(object sender, EventArgs e)
        {
            this.Close(); /* Close form */
        }

        public static void ShowAboutMessage()
        {

            AboutForm AboutMessage = new AboutForm(); /* Create object */
            AboutMessage.ShowDialog(); /* Show message */

        }

    }
}
