using System;
using System.Data.OleDb;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Correct file path for the database
            string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\USER\Downloads\EMPLOYEE1.accdb";

            // Establishing the connection
            OleDbConnection conn = new OleDbConnection(connectionString);

            // SQL query to fetch required data
            string sql = "SELECT NAME, ADDRESS, SALARY FROM E1";
            OleDbCommand cmd = new OleDbCommand(sql, conn);

            Console.WriteLine("Person Name\tAddress\t\tSalary");
            Console.WriteLine("===========================================");

            try
            {
                conn.Open(); // Open the connection

                // Executing the query
                using (OleDbDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        // Output data from the database
                        Console.WriteLine("{0}\t\t{1}\t\t{2}",
                            reader["NAME"].ToString(),
                            reader["ADDRESS"].ToString(),
                            reader["SALARY"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message); // Print any errors
            }
            finally
            {
                conn.Close(); // Close the connection
            }

            Console.ReadKey();
        }
    }
}
