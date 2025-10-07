using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp1
{
    public partial class LastOfStu : Form
    {
        public LastOfStu()
        {
            InitializeComponent();
        }

        private void LastOfStu_Load(object sender, EventArgs e)
        {
            List<Student> stus= new List<Student>();
            Student s1 = new(1, "Mohamed");
            Student s2 = new(2, "Nada");
            Student s3 = new(3, "Alaa");

            stus.Add(s1);
            stus.Add(s2);
            stus.Add(s3);

            foreach (var stu in stus)
            {
                textBox1.AppendText(stu.ToString() );
                
            }

        }
    }
}
