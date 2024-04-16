using System;
using System.Collections;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;

namespace SimpleDataAdapter
{
    internal class Program
    {
        public static void PrintDataSet(DataSet ds)
        {
            //Set DataSet name
            ds.DataSetName = "AutoLot DataSet";
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

        static void Main(String[] args)
        {
            //Declare database connection string 
            string db_connection = $"Server=LG-GRAM;Database=AutoLot;Trusted_Connection=True;";
            //Declare new DataSet
            DataSet ds = new DataSet();
            //Declare SQL query
            string sql_query = "SELECT * FROM Inventory";
            //Declare new DataAdapter
            DbDataAdapter adapter = new SqlDataAdapter(sql_query, db_connection);

            //Mapping Database Names to Friendly Names
            adapter.TableMappings.Add("Inventory", "Demo Inventory");
            DataTableMapping tablemapping = adapter.TableMappings["Inventory"];
            tablemapping.ColumnMappings.Add("CarId", "Car Id");
            tablemapping.ColumnMappings.Add("PetName", "Car Name");

            //Print DataSet
            adapter.Fill(ds, "Inventory");
            PrintDataSet(ds);
        }
    }
}
