//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class DataView2
//    {

//        static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=BRRIDGEON;Trusted_Connection=True;";
//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            {
//                connection.Open();
//                string Table = "SELECT * FROM StaffDetails;";
//                SqlDataAdapter dataAdapter = new SqlDataAdapter(Table, connection);
//                DataTable dataTable = new DataTable();
//                dataAdapter.Fill(dataTable);

         
//                DataView view = new DataView(dataTable);

//                foreach(DataRowView row in view)
//                {
//                    Console.WriteLine(row["Name"]);
//                }
//            }
//        }

//    }
//}
