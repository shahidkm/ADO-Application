//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class StoredProcedure1
//    {


//        static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=BRRIDGEON;Trusted_Connection=True;";

//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            {
//                connection.Open();
//                string storedProcedure = "STAFF";
//                SqlCommand command = new SqlCommand(storedProcedure, connection);
//                command.CommandType = CommandType.StoredProcedure;
//                //command.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
//                //command.Parameters["@id"].Value = 1;


//                command.Parameters.AddWithValue("@id", 1);
//                SqlDataReader reader = command.ExecuteReader();
//                while (reader.Read())
//                {
//                    Console.WriteLine(reader["Name"]);
//                }
//            }
//        }
//    }
//}
