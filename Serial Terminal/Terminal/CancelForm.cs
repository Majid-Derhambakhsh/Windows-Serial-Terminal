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
    public partial class CancelForm : Form
    {
        public CancelForm()
        {
            InitializeComponent();
        }

        private void CancelForm_Load(object sender, EventArgs e)
        {

            CancelForm_Timer.Start(); /* Start timer */
            CancelForm_BtnTimer.Start(); /* Start timer */
            CancelForm_PicBox.Enabled = true; /* Enable picture box */
            CancelForm_OkThinButton.Enabled = true; /* Enable button */

        }

        private void CancelForm_Timer_Tick(object sender, EventArgs e)
        {
            CancelForm_PicBox.Enabled = false; /* Disable picture box */
        }

        private void CancelForm_BtnTimer_Tick(object sender, EventArgs e)
        {

            CancelForm_Lbl.Visible = true; /* Show label */
            CancelForm_OkThinButton.Visible = true; /* Show button */
            CancelForm_BtnTimer.Stop(); /* Stop timer */

        }

        private void CancelForm_OkThinButton_Click(object sender, EventArgs e)
        {
            this.Close(); /* Close form */
        }

        public static void ShowCanceledMessage()
        {

            CancelForm CanceledMessage = new CancelForm(); /* Create object */
            CanceledMessage.ShowDialog(); /* Show message */

        }

    }
}
