//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class Work1
//    {

//        public static void Main()
//        {

//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=BRRIDGEON;Trusted_Connection=True;";

//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            {
//                connection.Open();

               

//                string query2 = "INSERT INTO StaffDetails(Id,Name,Salary) VALUES (@ID,@NAME,@SALARY);";
//                SqlCommand command1 = new SqlCommand(query2, connection);

//                command1.Parameters.AddWithValue("@ID", 4);
//                command1.Parameters.AddWithValue("@NAME", "MNHJA");
//                command1.Parameters.AddWithValue("@SALARY", 123334);

//                command1.ExecuteNonQuery();

//                string query3 = "DELETE FROM StaffDetails WHERE Id=@Id;";
//                using (SqlCommand command2 = new SqlCommand(query3, connection))
//                {
//                    command2.Parameters.AddWithValue("@Id", 4);
//                    command2.ExecuteNonQuery();
//                }

//                string query = "SELECT * FROM StaffDetails";
//                SqlCommand command = new SqlCommand(query, connection);
//                SqlDataReader reader = command.ExecuteReader();
//                while (reader.Read())
//                {
//                    Console.WriteLine(reader["Name"]);
//                }

               


//            }
//        }


//    }
//}
