namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {

        
            string constring = "Data Source=.;Initial Catalog=TestingAdo;Integrated Security=True;Trust Server Certificate=True";

          public Form1()
          {
             InitializeComponent();
          }




        private void btnLoad_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);
                con.Open();

                SqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    string name = reader["SName"].ToString();
                    string course = reader["CName"].ToString();
                    listBox1.Items.Add($"{name} - {course}");
                }
            }
        }

  
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string course = txtCourse.Text;

            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "INSERT INTO Student (SName, CName) VALUES (@n, @c)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n", name);
                cmd.Parameters.AddWithValue("@c", course);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"{rows} row inserted!");
            }
        }


        private void btnDelete_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            using (SqlConnection con = new SqlConnection(constring))
            {
                string query = "DELETE FROM Student WHERE SName = @n";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@n", name);

                con.Open();
                int rows = cmd.ExecuteNonQuery();
                MessageBox.Show($"{rows} row deleted!");
            }
        }
    }
}

       
 