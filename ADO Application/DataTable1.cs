//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class DataTable1
//    {
//        public static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=BRRIDGEON;Trusted_Connection=True;";
//            DataTable table = new DataTable();

//            using(SqlConnection connection=new SqlConnection(ConnectionString))
//            {
//                string query = "SELECT * FROM StaffDetails";
//                SqlCommand command = new SqlCommand(query, connection);
//                using(SqlDataAdapter adapter=new SqlDataAdapter(command))
//                {
//                    connection.Open();
//                    adapter.Fill(table);

//                    foreach(DataRow row in table.Rows)
//                    {
//                        Console.WriteLine(row["Salary"]);
//                    }

//                }
//            }

//        }

//    }
//}
