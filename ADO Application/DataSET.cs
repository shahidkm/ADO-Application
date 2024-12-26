//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Data.SqlClient;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    public class DataSET
//    {

//        public static void Main()
//        {
//            string ConnectionString= "Server=DESKTOP-GUAL8JH;Database=UnionDB;Trusted_Connection=True;";
//            using (SqlConnection conn = new SqlConnection(ConnectionString))
//            {
//                try
//                {
//                    DataSet dataSet = new DataSet();
//                    string query = "SELECT * FROM UnionDetail";
//                    SqlCommand command = new SqlCommand(query,conn);

//                    using(SqlDataAdapter dataAdapter=new SqlDataAdapter(command))
//                    {
//                        conn.Open();
//                        dataAdapter.Fill(dataSet, "UnionDetail");


//                        foreach(DataRow row in dataSet.Tables["UnionDetail"].Rows)
//                        {
//                            Console.WriteLine(string.Join("\t", row.ItemArray));
//                        }
//                    }
                    
                    
//                }
//                catch(Exception ex)
//                {
//                    Console.WriteLine(ex.Message);
//                }
//            }
//        }
//    }
//}
