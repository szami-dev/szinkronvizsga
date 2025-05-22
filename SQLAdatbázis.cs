using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;
using System.IO;

//TELEPÍTENI: TOOLS/NuGEt/MySqlConnector

namespace radioadok
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var server = new MySqlConnectionStringBuilder 
            { 
                Server = "127.0.0.1", 
                UserID = "root",
                Password = "", 
                Database = "radioadok" 
            };
            var kapcsolat = new MySqlConnection(server.ConnectionString);
            var sqlparancs = kapcsolat.CreateCommand();

            #region Kiosztás

            string[] kiosztasAdat = File.ReadAllLines("kiosztas.txt", Encoding.UTF8);

            sqlparancs.CommandText = "DROP TABLE IF EXISTS kiosztas; \n";
            sqlparancs.CommandText += $"CREATE TABLE kiosztas (azon INT AUTO_INCREMENT PRIMARY KEY, " +
                $"{kiosztasAdat[0].Split('\t')[0].Trim()} FLOAT," +
                $"{kiosztasAdat[0].Split('\t')[1].Trim()} FLOAT," +
                $"{kiosztasAdat[0].Split('\t')[2].Trim()} VARCHAR(255)," +
                $"{kiosztasAdat[0].Split('\t')[3].Trim()} VARCHAR(255)," +
                $"{kiosztasAdat[0].Split('\t')[4].Trim()} VARCHAR(255))";

            kapcsolat.Open();            
            var reader = sqlparancs.ExecuteReader();
            reader.Read();
            reader.Close();



            sqlparancs.CommandText = "insert into kiosztas (" +
                $"{kiosztasAdat[0].Split('\t')[0].Trim()}," +
                $"{kiosztasAdat[0].Split('\t')[1].Trim()}," +
                $"{kiosztasAdat[0].Split('\t')[2].Trim()}," +
                $"{kiosztasAdat[0].Split('\t')[3].Trim()}," +
                $"{kiosztasAdat[0].Split('\t')[4].Trim()}) VALUES ";

            for (int i = 1; i < kiosztasAdat.Length; i++)
            {
                sqlparancs.CommandText += "(" +                    
                $"{kiosztasAdat[i].Split('\t')[0].Trim()}," +
                $"{kiosztasAdat[i].Split('\t')[1].Trim()}," +
                $"'{kiosztasAdat[i].Split('\t')[2].Trim()}'," +
                $"'{kiosztasAdat[i].Split('\t')[3].Trim()}',";
                if (kiosztasAdat[i].Split('\t')[4].Trim() != "") sqlparancs.CommandText += $"'{kiosztasAdat[i].Split('\t')[4].Trim()}')";
                else sqlparancs.CommandText += $"NULL)";
                if (i != kiosztasAdat.Length - 1) sqlparancs.CommandText += $",\n";
            }

            Console.WriteLine(sqlparancs.CommandText);

            reader = sqlparancs.ExecuteReader();
            reader.Read();
            reader.Close();


            Console.WriteLine(sqlparancs.CommandText);



            #endregion


            #region Település

            string[] telepulesAdat = File.ReadAllLines("telepules.txt", Encoding.UTF8);

            sqlparancs.CommandText = "DROP TABLE IF EXISTS telepules; \n";
            sqlparancs.CommandText += $"CREATE TABLE telepules (" +
                $"{telepulesAdat[0].Split('\t')[0].Trim()} VARCHAR(255) PRIMARY KEY," +
                $"{telepulesAdat[0].Split('\t')[1].Trim()} VARCHAR(255))";

            reader = sqlparancs.ExecuteReader();
            reader.Read();
            reader.Close();

            sqlparancs.CommandText = "insert into telepules (" +
               $"{telepulesAdat[0].Split('\t')[0].Trim()}," +
               $"{telepulesAdat[0].Split('\t')[1].Trim()}) VALUES " ;

            for (int i = 1; i < telepulesAdat.Length; i++)
            {
                sqlparancs.CommandText += "(" +
                $"'{telepulesAdat[i].Split('\t')[0].Trim()}'," +
                $"'{telepulesAdat[i].Split('\t')[1].Trim()}')";
                if (i != telepulesAdat.Length - 1) sqlparancs.CommandText += $",\n";

            }

            Console.WriteLine(sqlparancs.CommandText);

            reader = sqlparancs.ExecuteReader();
            reader.Read();
            reader.Close();


            #endregion


            #region Régió
            string[] regioAdat = File.ReadAllLines("regio.txt", Encoding.UTF8);

            sqlparancs.CommandText = "DROP TABLE IF EXISTS regio; \n";
            sqlparancs.CommandText += $"CREATE TABLE regio (" +
                $"{regioAdat[0].Split('\t')[0].Trim()} VARCHAR(255)," +
                $"{regioAdat[0].Split('\t')[1].Trim()} VARCHAR(255) PRIMARY KEY)";

            reader = sqlparancs.ExecuteReader();
            reader.Read();
            reader.Close();

            sqlparancs.CommandText = "insert into regio (" +
               $"{regioAdat[0].Split('\t')[0].Trim()}," +
               $"{regioAdat[0].Split('\t')[1].Trim()}) VALUES ";

            for (int i = 1; i < regioAdat.Length; i++)
            {
                sqlparancs.CommandText += "(" +
                $"'{regioAdat[i].Split('\t')[0].Trim()}'," +
                $"'{regioAdat[i].Split('\t')[1].Trim()}')";
                if (i != regioAdat.Length - 1) sqlparancs.CommandText += $",\n";

            }

            Console.WriteLine(sqlparancs.CommandText);

            reader = sqlparancs.ExecuteReader();
            reader.Read();
            reader.Close();
            #endregion


            //ALTER TABLE kiosztas ADD CONSTAINT FOREIGN KEY (adohely) REFERENCES telepules

            sqlparancs.CommandText = "ALTER TABLE kiosztas ADD CONSTRAINT FOREIGN KEY (adohely) REFERENCES telepules(nev);";
            sqlparancs.CommandText += "ALTER TABLE telepules ADD CONSTRAINT FOREIGN KEY (megye) REFERENCES regio(megye)";

            reader = sqlparancs.ExecuteReader();
            reader.Read();
            reader.Close();









            kapcsolat.Close();



            Console.ReadKey();
        }
    }
}
