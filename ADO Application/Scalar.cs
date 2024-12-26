//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    public class Scalar
//    {

//        public static void Main()
//        {
//            string ConnectionString = "Server=DESKTOP-GUAL8JH;Database=BRRIDGEON;Trusted_Connection=True;";
//            using (SqlConnection connection = new SqlConnection(ConnectionString))
//            {

//                try {
//                    connection.Open();

//                    string query = "SELECT SUM(Salary) FROM StaffDetails";
//                    SqlCommand command = new SqlCommand(query, connection);

//                    object RESULT = command.ExecuteScalar();

//                    Console.WriteLine(RESULT.ToString());




//                }
//                catch(Exception ex)
//                {
//                    Console.WriteLine(ex.ToString());
//                }
//                }

//        }



//    }
//}
