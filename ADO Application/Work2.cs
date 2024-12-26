//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class Work2
//    {

//        static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=BRRIDGEON;Trusted_Connection=True;";

//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            {
//                connection.Open();

//                //string insert = "INSERT INTO StaffDetails(Id,Name,Salary) VALUES(@ID,@NAME,@SALARY);";
//                //SqlCommand insertCommand = new SqlCommand(insert, connection);
//                //insertCommand.Parameters.AddWithValue("@ID", 12);
//                //insertCommand.Parameters.AddWithValue("@NAME", "SINAN");
//                //insertCommand.Parameters.AddWithValue("@SALARY", 10009);
//                //insertCommand.ExecuteNonQuery();

//                string update = "UPDATE StaffDetails SET Name=@name WHERE Id=@id;";
//                SqlCommand updateCommand = new SqlCommand(update, connection);
//                updateCommand.Parameters.AddWithValue("@id", 1);
//                updateCommand.Parameters.AddWithValue("@name", "NIFRAS");
//                updateCommand.ExecuteNonQuery();

//                string query1 = "SELECT DISTINCT * FROM StaffDetails;";
//                 SqlCommand command1 = new SqlCommand(query1, connection);
//                SqlDataReader reader = command1.ExecuteReader();
//                while (reader.Read())
//                {
//                    Console.WriteLine(reader["Name"]);
//                }
//            }





//        }



//    }
//}
