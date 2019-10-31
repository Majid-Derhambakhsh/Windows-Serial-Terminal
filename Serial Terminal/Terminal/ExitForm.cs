using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class ExitForm : Form
    {
        public ExitForm()
        {
            InitializeComponent();
        }

        private void ExitThinButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); /* Close application */
        }

        private void CancelThinButton_Click(object sender, EventArgs e)
        {
            this.Close(); /* Close form */
        }

        public static void ShowExitMessage()
        {

            ExitForm ExitMessage = new ExitForm(); /* Create object */
            ExitMessage.ShowDialog(); /* Show message */

        }

    }
}
