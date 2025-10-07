using Microsoft.Data.SqlClient;
using System.Data;

namespace Task7CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            string constring = "Data Source=.;Initial Catalog=TestingAdo;Integrated Security=True;Trust Server Certificate=True";

            using (SqlConnection con = new SqlConnection(constring))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Student", con);

                DataTable dtstu = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                SqlCommandBuilder sqlCommand = new SqlCommandBuilder(adapter);
                adapter.InsertCommand = sqlCommand.GetInsertCommand();
                adapter.Fill(dtstu);

                //foreach (DataRow dr in dtstu.Rows)
                //{
                //    Console.WriteLine($"{dr[0]} - {dr[1]} - {dr[2]}");
                //}
                //convert flat odj to stu

                foreach (DataRow dr in dtstu.Rows)
                {
                    int.TryParse(dr[0]?.ToString(), out int stuid);
                    string stuname = dr[1]?.ToString();
                    string stucourse = dr[2]?.ToString();
                    Student student = new Student()
                    {
                        Id = stuid,
                        SName = stuname,
                        CName = stucourse

                    };
                    students.Add(student);
                }

                //new data row-insert
                DataRow drnew = dtstu.NewRow();
                drnew[1] = "momo";
                drnew[2] = "c#";

                Console.WriteLine($"{drnew[1]}-{drnew[2]}");
                dtstu.Rows.Add(drnew);
                foreach (DataRow dr in dtstu.Rows)
                    Console.WriteLine($"{dr[1]}-{dr[2]}");



                adapter.Update(dtstu);
                //update
                dtstu.Rows[1][1] = "Desouky";
                adapter.Update(dtstu);
                //delete
                dtstu.Rows[1].Delete();
                adapter.Update(dtstu);




            }




        }
    }
}
