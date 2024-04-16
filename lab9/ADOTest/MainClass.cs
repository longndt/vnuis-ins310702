using DocumentFormat.OpenXml.Bibliography;
using System;
using System.Data.Common;
using System.Data.SqlClient;  

namespace ADOTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            try
            {
                //Establish the connection between .NET and SQL Server with ADO.NET using 1 of 2 below methods

                /* 
                1st method: use SQL Server Authentication
                Note 1: Replace the placeholder values with your actual server name, database name, user ID, and password
                Note 2: Default database username (userid) is "sa" and password has been set from installation step => reset pass if your forgot
                */
                //using (SqlConnection connection = new SqlConnection("Server=localhost;Database=AutoLot;User Id=sa;Password=123456;"))

                /*
                2nd method: use Windows Authentication
                Note 1: Replace the placeholder values with your actual server name, database name
                Note 2: use "Integrated Security=True;"
                */
                using (SqlConnection connection = new SqlConnection("Server=LG-GRAM;Database=AutoLot;Trusted_Connection=True;"))
                {
                    // Open DB connection
                    connection.Open();
                    // Make a command
                    DbCommand cmd = connection.CreateCommand();
                    // Set query
                    cmd.CommandText = "SELECT * FROM Inventory";
                    // execute query 
                    using (DbDataReader dataReader = cmd.ExecuteReader())
                    {
                        // using loop to traverse each record in table
                        while (dataReader.Read())
                        {
                            // display data to console
                            Console.WriteLine($"Car {dataReader["CarId"]} is a {dataReader["Make"]}.");
                        }
                    }
                    // Close DB connection
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                //display DB connection error
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}