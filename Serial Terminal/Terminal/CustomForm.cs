using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Terminal
{
    public partial class CustomForm : Form
    {
        public CustomForm(System.Drawing.Color _color,System.Drawing.Image _image,string _message)
        {
            InitializeComponent();

            CustomForm_Timer.Start(); /* Start timer */

            CustomForm_Panel.BackColor = _color;

            CustomPicBox.Image = _image;

            CustomLbl.Text = _message; /* Set message */
            CustomLbl.TextAlign = ContentAlignment.MiddleCenter; /* Set align */

        }

        private void CustomForm_Paint(object sender, PaintEventArgs e)
        {

            Graphics graph; /* Create object */

            graph = this.CreateGraphics(); /* Create graphic in form */
            Pen myPen = new Pen(Color.FromArgb(250, 98, 95)); /* Set color */
            myPen.Width = 0.5f; /* Set width */
            graph.DrawRectangle(myPen, 0, 0, 498, 298); /* Draw rectangle */

        }

        private void LoadPicBox_Click(object sender, EventArgs e)
        {
            this.Close(); /* Close form */
        }

        public static void ShowCustomMessage(System.Drawing.Color color,System.Drawing.Image image,string message)
        {

            CustomForm CustomMessage = new CustomForm(color,image,message); /* Create object */
            CustomMessage.ShowDialog(); /* Show message */

        }

        private void CustomForm_Timer_Tick(object sender, EventArgs e)
        {
            
            CustomForm_Timer.Stop(); /* Stop timer */
            this.Close(); /* Close form */

        }

    }
}
