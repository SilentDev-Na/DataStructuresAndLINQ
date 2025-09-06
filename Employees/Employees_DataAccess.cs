using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DataStructuresAndLINQ.Employees
{
    internal class Employees_DataAccess
    {



        public static string ConnString = "Server = .; Database = C21_DB;User ID = sa ; Password = sa123456";

        public static async Task<List<Employees>> GetEmps()
        {
            List<Employees> employees = new List<Employees>();

            string query = "SELECT * FROM Employees2";

            try
            {
                using (SqlConnection conn = new SqlConnection(ConnString))
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    await conn.OpenAsync();
                    using (SqlDataReader reader = await cmd.ExecuteReaderAsync())
                    {

                        while (await reader.ReadAsync())
                        {
                            Employees emps = new Employees()
                            {
                                Name = reader["Name"] as string,
                                Department = reader["Department"] as string,
                                Salary = (decimal)reader["Salary"],
                                PerformanceRating = (int)reader["PerformanceRating"]
                            };

                            employees.Add(emps);
                        }
                    }
                }
            }
            catch (SqlException ex)
            {
                WriteLine("Sql Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                WriteLine("Error: " + ex.Message);
            }

            return employees;
        }

    }
}
