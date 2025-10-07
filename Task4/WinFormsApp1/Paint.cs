using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    public partial class Paint : Form
    {
        public Paint()
        {
            InitializeComponent();
        }

        private void Paint_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics grx = CreateGraphics();
            Brush br=new SolidBrush(BackColor);
            if (e.Button == MouseButtons.Right) {
                grx.FillEllipse(Brushes.Red,e.X-25,e.Y-25,25,25);
            
            }
            else if(e.Button == MouseButtons.Left) {
                grx.FillEllipse(br, e.X - 25, e.Y - 25, 150, 150);

            }

        }
    }
}
