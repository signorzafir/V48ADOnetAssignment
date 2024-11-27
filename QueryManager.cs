using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace V48ADOnetAssignment
{
    internal class QueryManager
    {
        internal static SqlCommand SearchByActor(SqlConnection connectionString)
        {

            string firstName = Menu.GetActorFirstName().ToUpper();
            string lastName = Menu.GetActorLastName().ToUpper();

            string searchQuery = "SELECT A.first_name, A.last_name, f.title " + "FROM actor A " +
                "INNER JOIN film_actor FM ON FM.actor_id = A.actor_id " +
                "INNER JOIN film F ON F.film_id = FM.film_id " +
                "WHERE A.first_name = @firstName AND A.last_name = @lastName " +
                "ORDER BY A.first_name ASC, A.last_name ASC, F.title ASC";

            SqlCommand sqlCommand = new SqlCommand(searchQuery, connectionString);
            sqlCommand.Parameters.AddWithValue("@firstName", firstName);
            sqlCommand.Parameters.AddWithValue("@lastName", lastName);

            return sqlCommand;
        }
        internal static void PrintResult(SqlConnection sql_connection, SqlCommand sqlCommand)
        {
            try
            {
                sql_connection.Open();
                var result = sqlCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Console.WriteLine($"First Name : {result[0]} -- " +
                            $"Last Name : {result[1]} -- " +
                            $"Film Title : {result[2]}");
                    }
                }
                else
                {
                    Console.WriteLine("There is no data to show.");
                }
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"DataBase Error {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
            }
            finally
            {
                sql_connection.Close();
            }


        }
    }


}
