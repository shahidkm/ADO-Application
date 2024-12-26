//using System;
//using System.Collections.Generic;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    public class Program
//    {
//      public static string connectionString="Server=DESKTOP-GUAL8JH;Database=UnionDB;Trusted_Connection=True;";


//        static void Main(string[] args)
//        {
//            using (SqlConnection Connection = new SqlConnection(connectionString))
//            {
//                try
//                {
//                    Connection.Open();
//                    Console.WriteLine("CONNECTED SUCCESSFULLY");

//                    string query = "SELECT * FROM UnionDetail";

//                    SqlCommand command = new SqlCommand(query, Connection);
//                    SqlDataReader Reader = command.ExecuteReader();

//                    while (Reader.Read())
//                    {
//                        Console.WriteLine(Reader["Name"]);
//                    }

//                    string quer1 = "ALTER TABLE UnionDetail ADD Balance INT";
//                    SqlCommand command1 = new SqlCommand(quer1, Connection);
//                     command1.ExecuteNonQuery();

//                    SqlCommand command2 = new SqlCommand("INSERT INTO UnionDetail(ID,Name,Year,Balance)VALUES (@id,@name,@year,@balance)",Connection);
//                    command2.Parameters.AddWithValue("@id", 4);
//                    command2.Parameters.AddWithValue("@name", "shahid");
//                    command2.Parameters.AddWithValue("@year", 1232);
//                    command2.Parameters.AddWithValue("@balance", 123333);
                    
//                    command2.ExecuteNonQuery();

//                    //SqlCommand command3 = new SqlCommand("SELECT * FROM UnionDetail");
//                    //SqlDataReader reader = command3.ExecuteReader();
//                    //while (reader.Read())
//                    //{
//                    //    Console.WriteLine(reader["Name"]);
//                    //}
//                }


//                catch(Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//            }



//        }
//    }
//}
