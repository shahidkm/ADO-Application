//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ADO_Application
//{
//    internal class DataView1
//    {

//        static void Main()
//        {
//            DataTable table = new DataTable();
//            table.Columns.Add("Id", typeof(int));
//            table.Columns.Add("Name", typeof(string));

//            table.Rows.Add(1, "SHAHID");
//            table.Rows.Add(2, "MINHAJ");

//            DataView view = new DataView(table);
//            view.RowFilter = "Id>1";
//            //view.Sort = "Id>1";

//            foreach (DataRowView row in view)
//            {
//                Console.WriteLine(row["Name"]);
//            }
//        }
//    }
//}
