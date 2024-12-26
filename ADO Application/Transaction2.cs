//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class Transaction2
//    {


//     public static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=BRRIDGEON;Trusted_Connection=True;";

//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            {
//                connection.Open();
//                SqlTransaction transaction = connection.BeginTransaction();
//                try
//                {

//                    string operation1 = "SELECT SUM(Salary) FROM StaffDetails";
//                    SqlCommand command1 = new SqlCommand(operation1, connection,transaction);
//                    var result = command1.ExecuteScalar();
//                    Console.WriteLine(result.ToString());


//                    string operation2 = "SELECT * FROM StaffDetails;";
//                    SqlCommand command2 = new SqlCommand(operation2, connection,transaction);
//                    SqlDataReader reader = command2.ExecuteReader();

//                    while (reader.Read())
//                    {
//                        Console.WriteLine(reader["Id"]);
//                    }

//                    transaction.Commit();
//                    Console.WriteLine("TRANSACTION SUCCESSED");

                    


//                }
//                catch(Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                    transaction.Rollback();
//                }

//            }


//        }
//    }
//}
