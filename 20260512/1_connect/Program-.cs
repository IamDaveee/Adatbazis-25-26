using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.MySql.Data;
using MySql.Data.MySqlClient;

namespace Adatbázis_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = "Server=localhost;Database=ostermelok;Uid=root;Pwd=;";

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Sikeres kapcsolódás;");

                    //lekérdezés készítése - select query
                    string query = "select * from gyumolcslevek";

                    MySqlCommand command = new MySqlCommand(query, connection);

                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["id"]} - {reader["gynev"]}");
                    }
                    //SELECT művelet befejezése
                    reader.Close();

                    // INSERT lekérdezés
                    string insertQuery = "INSERT INTO gyumolcslevek (id, gynev) VALUES (@id, @gynev)";
                    using (MySqlCommand insertCommand = new MySqlCommand(insertQuery, connection))
                    {
                        insertCommand.Parameters.AddWithValue("@id", 2);
                        insertCommand.Parameters.AddWithValue("@gynev", "körtelé");

                        int rowsAffected = insertCommand.ExecuteNonQuery();
                        Console.WriteLine($"{rowsAffected} sor lett beszúrva.");
                    }




                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba: " + ex.Message);
                }
                //ha using blokkot használok, akkor a finally blokkban a connection.Close() redundáns
                finally
                {
                    connection.Close();
                }
            }//using
            Console.ReadKey();
        }
    }
}
