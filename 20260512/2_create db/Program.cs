using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Adatbázis_Konyv_Kolcsonzes_Olvaso_Kiado
{
    class Program
    {
        static void CreateDB()
        {
            string connString = "Server=localhost;Uid=root;Pwd=;";
            using (MySqlConnection connection = new MySqlConnection(connString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Sikeres kapcsolódás.");
                    string createDbQuery = @"CREATE DATABASE IF NOT EXISTS konyvtar
                                           DEFAULT CHARACTER SET utf8
                                           COLLATE utf8_hungarian_ci";
                    MySqlCommand createCommand = new MySqlCommand(createDbQuery, connection);
                    /*
                     * A command.ExecuteNonQuery(); egy ADO.NET parancs, 
                     * amelyet akkor használsz, amikor egy SQL parancsot szeretnél 
                     * futtatni az adatbázisban, de a parancs nem ad vissza adatokat.
                     * Ilyen például az INSERT, UPDATE, DELETE, vagy az ALTER utasítások.
                     */

                    createCommand.ExecuteNonQuery();
                    Console.WriteLine("Az adatbázis létrejött.");
                }
                catch (Exception ex)
                {

                    Console.WriteLine("Hiba: " + ex.Message);
                }
            }

        }

        static void CreateTable()
        {
            string connString = "Server=localhost;Database=konyvtar;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string createTableQuery_1 = @"CREATE TABLE IF NOT EXISTS konyvek(
                                                    konyvid int primary key auto_increment,
                                                    cim varchar(20),
                                                    szerzo varchar(30),
                                                    kiadaseve int,
                                                    kolcsonozve boolean default false,
                                                    oldalszam int,
                                                    borito boolean default false
                                                    );
                                                    ";

                    MySqlCommand createTableCommand = new MySqlCommand(createTableQuery_1, conn);
                    createTableCommand.ExecuteNonQuery();
                    Console.WriteLine("A 'konyvek' tábla elkészült.");

                    string createTableQuery_2 = @"CREATE TABLE IF NOT EXISTS olvasok(
                                                    olvasoid int primary key auto_increment,
                                                    nev varchar(20),                                                   
                                                    kor int,
                                                    email varchar(30)
                                                    );
                                                    ";

                    MySqlCommand createTableCommand2 = new MySqlCommand(createTableQuery_2, conn);
                    createTableCommand2.ExecuteNonQuery();
                    Console.WriteLine("Az 'olvasok' tábla elkészült.");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba: " + ex.Message);
                }
            }
        }

        static void InsertInto()
        {
            string connString = "Server=localhost;Database=konyvtar;Uid=root;Pwd=;";
            using (MySqlConnection conn = new MySqlConnection(connString))
            {
                try
                {
                    conn.Open();
                    string insertQuery_1 = @"INSERT IGNORE INTO 
                                             Konyvek (cim, szerzo, kiadasEve, kolcsonozve, oldalszam, borito)
                                             VALUES ('Könyv 1', 'Író 1', 2000, FALSE, 300, FALSE),
                                                    ('Könyv 2', 'Író 2', 2005, TRUE, 250, TRUE),
                                                    ('Könyv 3', 'Író 3', 2010, FALSE, 400, FALSE),
                                                    ('Könyv 4', 'Író 4', 2015, TRUE, 500, TRUE),
                                                    ('Könyv 5', 'Író 5', 2020, FALSE, 350, FALSE);";
                    MySqlCommand insertCommand = new MySqlCommand(insertQuery_1, conn);
                    insertCommand.ExecuteNonQuery();
                    Console.WriteLine("Az adatok beszúrás a 'Konyvek' táblába megtörtént");

                    string insertQuery_2 = @"INSERT IGNORE INTO Olvasok (nev, kor, email)
                                             VALUES ('Sanyi', 18, 'sanyi@email.hu' ),
                                                    ('Peti', 34, 'peti@email.hu'),
                                                    ('Géza', 22, 'geza@email.hu'),
                                                    ('Erzsi', 40, 'erzsi@email.hu'),
                                                    ('Béla', 19, 'bela@email.hu');";
                    MySqlCommand insertCommand2 = new MySqlCommand(insertQuery_2, conn);
                    insertCommand2.ExecuteNonQuery();
                    Console.WriteLine("Az adatok beszúrás a 'Olvasok' táblába megtörtént");
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Hiba: " + ex.Message);
                }
            }
        }
        static void Main(string[] args)
        {
            CreateDB();
            CreateTable();
            InsertInto();
            Console.ReadKey();
        }
    }
}
