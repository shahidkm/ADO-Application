//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class StoreProcedure2
//    {
//        public static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=DataBase1;Trusted_Connection=True;";
//            SqlConnection connection = new SqlConnection(ConnectionString);

//            connection.Open();
//            string StoredProcedure = "EmployeeStore";
//            SqlCommand command = new SqlCommand(StoredProcedure, connection);
//            command.CommandType = CommandType.StoredProcedure;
//            command.Parameters.AddWithValue("@id", 1);

//            SqlDataReader reader = command.ExecuteReader();

//            while (reader.Read())
//            {
//                Console.WriteLine(reader["Name"]);
//            }

//            connection.Close();
//        }

//    }
//}
