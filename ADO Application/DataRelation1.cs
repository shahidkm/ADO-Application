//using System;
//using System.Data;

//namespace ADO_Application
//{
//    internal class DataRelation1
//    {
//        public static void Main()
//        {
//            // Create the Parent table
//            DataTable Parent = new DataTable();
//            Parent.Columns.Add("ParentId", typeof(int));
//            Parent.Columns.Add("Name", typeof(string));
//            Parent.Rows.Add(1, "SHAHID");
//            Parent.Rows.Add(2, "MINHAJ");

//            // Create the Child table
//            DataTable Child = new DataTable();
//            Child.Columns.Add("ChildId", typeof(int));
//            Child.Columns.Add("ParentId", typeof(int));
//            Child.Columns.Add("Name", typeof(string));
//            Child.Rows.Add(1, 1, "MUHAMMED");
//            Child.Rows.Add(2, 2, "HISHAM");

//            // Create DataSet and add tables
//            DataSet dataSet = new DataSet();
//            dataSet.Tables.Add(Parent);
//            dataSet.Tables.Add(Child);

//            // Create a DataRelation to establish the parent-child relationship
//            DataRelation relation = new DataRelation("parent-child", Parent.Columns["ParentId"], Child.Columns["ParentId"]);
//            dataSet.Relations.Add(relation);

//            // Iterate through each row of the Parent table
//            foreach (DataRow parentRow in Parent.Rows)
//            {
//                Console.WriteLine($"Parent: {parentRow["Name"]}");

//                // Get the related child rows for this parent row using GetChildRows
//                DataRow[] childRows = parentRow.GetChildRows(relation);

//                // Iterate through the related child rows and print their names
//                foreach (DataRow childRow in childRows)
//                {
//                    Console.WriteLine($"  Child: {childRow["Name"]}");
//                }
//            }
//        }
//    }
//}
