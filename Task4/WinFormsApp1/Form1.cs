namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Nada" && textBox2.Text == "1234")
                MessageBox.Show("Login Successful!");
            else
                MessageBox.Show("Invalid username or password");
        }
    }
}
