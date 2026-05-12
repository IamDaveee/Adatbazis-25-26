using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Adatbázis
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("szia");
            string connectionString = "Server=localhost;Database=ostermelo; Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    // Kapcsolódás az adatbázishoz
                    connection.Open();
                    Console.WriteLine("Sikeres kapcsolódás!");

                    // SQL lekérdezés végrehajtása
                    string query = "SELECT * FROM gyumolcslevek";
                    MySqlCommand command = new MySqlCommand(query, connection);

                    // Adatok olvasása
                    MySqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        Console.WriteLine($"{reader["id"]} - {reader["gynev"]}");
                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    // Hiba kezelése
                    Console.WriteLine($"Hiba történt: {ex.Message}");
                }
            }
            Console.ReadKey();
        }
    }
}
