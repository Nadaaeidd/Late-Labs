using Microsoft.Data.SqlClient;

namespace Task6Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //select
            string connString = "Data Source=.;Initial Catalog=TestingAdo;Integrated Security=True;Trust Server Certificate=True";

            //using (SqlConnection conn = new SqlConnection(connString))
            //{
            //  
            //    SqlCommand cmd = new SqlCommand("SELECT * FROM Student", conn);

            //    conn.Open();

            //    using (SqlDataReader r = cmd.ExecuteReader())
            //    {
            //        while (r.Read())
            //        {

            //            Console.WriteLine(r[1].ToString());
            //        }
            //    }
            //}

            //insert
            //SqlConnection conn = new SqlConnection(connString);
            //SqlCommand cmd = new SqlCommand("insert into Student values ('Mohamed','.Net')", conn);
            //conn.Open();
            //int r = cmd.ExecuteNonQuery();
            //Console.WriteLine(r);
            //conn.Close();
            //delete
            string StueName = "dalia";
            SqlConnection conn = new SqlConnection(connString);
            SqlCommand cmd = new SqlCommand("delete from Student  where SName= @c ", conn);
            SqlParameter p1 = new SqlParameter("c", StueName);
            cmd.Parameters.Add(p1);
            conn.Open();
            object r = cmd.ExecuteNonQuery();
            Console.WriteLine(r);
            conn.Close();

        }
    }
}
