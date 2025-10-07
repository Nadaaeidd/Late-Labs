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
    public partial class Ballcs : Form
    {
        public Ballcs()
        {
            InitializeComponent();
        }
        int x = 0;
        private void Ballcs_Paint(object sender, PaintEventArgs e)
        {
            Graphics grx = e.Graphics;
            grx.FillEllipse(Brushes.Red, x, 20, 25, 25);

        }
        bool checkballdir = true;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(checkballdir)

                x += 5;
            else
                x -= 5;


            if(x>ClientSize.Width-25)
                checkballdir=false;
            else if(x<=0)
                checkballdir = true;

                this.Invalidate();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
