//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class DataSet1
//    {

//        public static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=BRRIDGEON;Trusted_Connection=True;";
//            DataSet dataSet = new DataSet();
//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            {
//                try
//                {
//                    connection.Open();
//                    String query = "SELECT * FROM StaffDetails";
//                    SqlCommand command = new SqlCommand(query, connection);

//                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
//                    {
//                        adapter.Fill(dataSet, "StaffDetails");


//                        foreach (DataRow row in dataSet.Tables["StaffDetails"].Rows)
//                        {
//                            Console.WriteLine(row["Name"]);
//                        }


//                    }
//                }
//                catch(Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//                }
//        }

//    }
//}