//using System;
//using System.Data;

//namespace ADO_Application
//{
//    internal class DataViewExample // Changed class name to avoid conflict
//    {
//        public static void Main()
//        {
//            // Create a DataTable and add columns
//            DataTable table = new DataTable();
//            table.Columns.Add("Id", typeof(int));
//            table.Columns.Add("Name", typeof(string));

//            // Add rows to the DataTable
//            table.Rows.Add(1, "SHAHID");
//            table.Rows.Add(2, "HISHAM");

//            // Create a DataView for the DataTable
//            DataView view = new DataView(table);

//            // Loop through the DataView and print rows
//            foreach (DataRowView row in view)


//            {


//                if ((int)row["Id"] = 1)
//                    Console.WriteLine(row["Name"]); // Corrected case of column name
//            }
//        }
//    }
//}
