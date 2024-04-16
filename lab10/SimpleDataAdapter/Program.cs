using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleDataAdapter
{
    internal class Program
    {
        public static void PrintDataSet(DataSet ds)
        {
            Console.WriteLine($"DataSet Name: {ds.DataSetName}");
            foreach (DictionaryEntry item in ds.ExtendedProperties)
            {
                Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
            }
            //Write the tables
            foreach (DataTable tbl in ds.Tables)
            {
                Console.WriteLine($"Table name: {tbl.TableName}");
                foreach (DataColumn col in tbl.Columns)
                {
                    Console.Write($"{col.ColumnName}\t");
                }
                Console.WriteLine();
                foreach (DataRow row in tbl.Rows)
                {
                    foreach (DataColumn col in tbl.Columns)
                    {
                        Console.Write($"{row[col]}\t");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            string conStr = $"Server=LG-GRAM;Database=AutoLot;Trusted_Connection=True;";
            DataSet ds = new DataSet();
            DbDataAdapter adapter = new SqlDataAdapter("select * from Inventory", conStr);

            //Mapping Database Names to Friendly Names
            adapter.TableMappings.Add("Inventory", "Current Inventory");
            DataTableMapping tablemapping = adapter.TableMappings["Inventory"];
            tablemapping.ColumnMappings.Add("CarId", "Car Id");
            tablemapping.ColumnMappings.Add("PetName", "Car Name");

            //Print DataSet
            adapter.Fill(ds, "Inventory");
            PrintDataSet(ds);
            Console.ReadLine();

            //LINQ over DataTable (1)
            //adapter.Fill(ds, "Inventory");
            //DataTable tbl = ds.Tables[0];
            //var subset = from car in tbl.AsEnumerable()
            //             where ((string)car["Color"]).Equals("Black")
            //             select car;
            //foreach (var item in subset)
            //{
            //    Console.WriteLine($"{item["PetName"]} is {item["Color"]}");
            //}
            //Console.ReadLine();

            //LINQ over DataTable (2)
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
            //Console.ReadLine();

            //Hydrating New DataTables from LINQ Queries
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
            //Console.ReadLine();
        }
    }
}
