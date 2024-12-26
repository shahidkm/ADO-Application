//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class Trannsaction1
//    {
//        public static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=BRRIDGEON;Trusted_Connection=True;";
//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            {
//                connection.Open();

//                SqlTransaction transaction = connection.BeginTransaction();
//                try
//                {

//                    string query1 = "UPDATE StaffDetails SET Salary =Salary - @x WHERE Id=@id1";
//                    SqlCommand command1 = new SqlCommand(query1, connection,transaction);
//                    command1.Parameters.AddWithValue("@x", 1000);
//                    command1.Parameters.AddWithValue("@id1", 2);
//                    command1.ExecuteNonQuery();



//                    string query2 = "UPDATE StaffDetails SET Salary=Salary - @x WHERE Id=@id2";
//                    SqlCommand command2 = new SqlCommand(query2, connection,transaction);
//                    command2.Parameters.AddWithValue("@x", 1000);
//                    command2.Parameters.AddWithValue("@id2", 3);
//                    command2.ExecuteNonQuery();
//                    transaction.Commit();
//                    Console.WriteLine("TRANSACTION COMPLETED");
//                }
//                catch
//                {
//                    Console.WriteLine("transaction failed");
//                    transaction.Rollback();
//                }

//            }

//        }
//    }
//}
