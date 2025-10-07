namespace AdoOnForm
{ 
using Microsoft.Data.SqlClient;

    public partial class Form1 : Form
    {
        string connString = "Data Source=.;Initial Catalog=TestingAdo;Integrated Security=True;Trust Server Certificate=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            using (SqlConnection conn = new SqlConnection(connString))
            {
                
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", conn);

                conn.Open();

                using (SqlDataReader r = cmd.ExecuteReader())
                {
                    while (r.Read())
                    {

                        listBox1.Items.Add(r[1].ToString()+"-"+r[2].ToString());
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StuToBeDeletedcs stuDel = new StuToBeDeletedcs();
            stuDel.ShowDialog();
            if (stuDel.ShowDialog() == DialogResult.OK)
            {

                string StueName = stuDel.Name;
                SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand("delete from Student  where SName= @c ", conn);
                SqlParameter p1 = new SqlParameter("c", StueName);
                cmd.Parameters.Add(p1);
                conn.Open();
                object r = cmd.ExecuteNonQuery();
                listBox1.Items.Add("Number of rows effected " + r.ToString());
                conn.Close();
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            StuToBeDeletedcs stuDel = new StuToBeDeletedcs();
            stuDel.ShowDialog();
            if (stuDel.ShowDialog() == DialogResult.OK)
            {
                string Name = stuDel.Name;
            SqlConnection conn = new SqlConnection(connString);
                SqlCommand cmd = new SqlCommand($"insert into Student (SName) values (@SNam)", conn);
                SqlParameter p1=new SqlParameter("SNam", Name);
                cmd.Parameters.Add(p1);
                conn.Open();
                
                int r = cmd.ExecuteNonQuery();
                listBox1.Items.Add("Number of rows effected " + r.ToString());
                conn.Close();
            }

        }


    }
}
