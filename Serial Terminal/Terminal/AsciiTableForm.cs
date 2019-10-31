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
    public partial class AsciiTableForm : Form
    {
        public AsciiTableForm()
        {
            InitializeComponent();
        }

        private void AsciiTableForm_OkThinButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public static void ShowAsciiTable()
        {
            AsciiTableForm AsciiTable = new AsciiTableForm();

            AsciiTable.ShowDialog();

        }

    }
}
