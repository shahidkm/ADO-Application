//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    public class DataTable
//    {
//        public static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=UnionDB;Trusted_Connection=True;";
//            DataTable dataTable = new DataTable();
//            using (SqlConnection Connection = new SqlConnection(ConnectionString))
//            {

//                try
//                {
//                    string query = "SELECT * FROM UnionDetail";
                 
//                    SqlCommand command = new SqlCommand(query, Connection);

//                    using (SqlDataAdapter dataAdapter = new SqlDataAdapter(command))
//                    {
//                        Connection.Open();
//                        dataAdapter.Fill(dataTable);


//                        foreach(DataRow row dataTable.Rows)
//                        {
//                            Console.WriteLine(row);
//                        }

//                    }

//                }
//                catch(Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }


//            }
//        }
//    }
//}