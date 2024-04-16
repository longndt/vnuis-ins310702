using System;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace DataAdapterWithLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare database connection string 
            string db_connection = $"Server=LG-GRAM;Database=AutoLot;Trusted_Connection=True;";
            //Declare new DataSet
            DataSet ds = new DataSet();
            //Declare SQL query
            string sql_query = "SELECT * FROM Inventory";
            //Declare new DataAdapter
            DbDataAdapter adapter = new SqlDataAdapter(sql_query, db_connection);

            //A) LINQ over DataTable (1)
            adapter.Fill(ds, "Inventory");
            DataTable tbl = ds.Tables[0];
            var subset = from car in tbl.AsEnumerable()
                         where ((string)car["Color"]).Equals("Black")
                         select car;
            foreach (var item in subset)
            {
                Console.WriteLine($"{item["PetName"]} is {item["Color"]}");
            }
 
            //B) LINQ over DataTable (2)
            //adapter.Fill(ds, "Inventory");
            //DataTable tbl = ds.Tables[0];
            //var cars = from car in tbl.AsEnumerable()
            //           where car.Field<string>("Color") == "Black"
            //           select new
            //           {
            //               ID = car.Field<int>("CarID"),
            //               Make = car.Field<string>("Make"),
            //               Color = car.Field<string>("Color")
            //           };
            //foreach (var item in cars)
            //{
            //    Console.WriteLine($"Car {item.ID} is a {item.Color} {item.Make}");
            //}   

            //C) Hydrating New DataTables from LINQ Queries
            //adapter.Fill(ds, "Inventory");
            //DataTable tbl = ds.Tables[0];
            //var cars = from car in tbl.AsEnumerable()
            //           where car.Field<string>("Color") == "Black"
            //           select car;
            //DataTable newTbl = cars.CopyToDataTable();
            //foreach (DataRow row in newTbl.Rows)
            //{
            //    foreach (DataColumn col in newTbl.Columns)
            //    {
            //        Console.Write($"{row[col]}\t");
            //    }
            //    Console.WriteLine();
            //}
        }
    }
}
