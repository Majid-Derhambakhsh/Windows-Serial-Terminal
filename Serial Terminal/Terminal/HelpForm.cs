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
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
        }

        private void HelpForm_OkThinButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        public static void ShowHelpMessage()
        {
            HelpForm HelpMessage = new HelpForm();

            HelpMessage.ShowDialog();

        }

    }
}
