using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using System.Configuration;

namespace ToDB
{
    class Program
    {
       
        static void Main(string[] args) 
        {
            //Простейшее консольное приложение для добавления страны из текстового файла в базу данных.
            //Континенты нужно заполнять самому, так же после необходимо скопировать файл с готовой БД.
            SQLiteConnection connection = new SQLiteConnection(ConfigurationManager.ConnectionStrings["connection"].ConnectionString);
            connection.Open();
            Console.WriteLine("Выберите континент для добавления стран в список: ");
            Console.Write("1 - Евразия, 2 - Африка, 3 - Северная Америка, 4 - Южная Америка, 5 - Австралия: ");
            int Continent = int.Parse(Console.ReadLine());
            string path;
            string line;
            switch (Continent)
            {

                case 1:
                    path = $"D:\\C#\\WorldAtlas\\EuroAsia.txt";
                    StreamReader reader = new StreamReader(path);
                    while ((line = reader.ReadLine()) != null)
                    {
                        string insertstring = $"INSERT INTO COUNTRY(COUNTRY,IDOFCONT) VALUES ('{line}', {1})";
                        SQLiteCommand insertcommand = new SQLiteCommand(insertstring,connection);
                        insertcommand.ExecuteNonQuery();
                    }
                    break;
                case 2:
                    path = $"D:\\C#\\WorldAtlas\\Africa.txt";
                    reader = new StreamReader(path);
                    while ((line = reader.ReadLine()) != null)
                    {
                        string insertstring = $"INSERT INTO COUNTRY(COUNTRY,IDOFCONT) VALUES ('{line}', {2})";
                        SQLiteCommand insertcommand = new SQLiteCommand(insertstring, connection);
                        insertcommand.ExecuteNonQuery();
                    }
                    break;
                case 3:
                    path = $"D:\\C#\\WorldAtlas\\NorthAmerica.txt";
                    reader = new StreamReader(path);
                    while ((line = reader.ReadLine()) != null)
                    {
                        string insertstring = $"INSERT INTO COUNTRY(COUNTRY,IDOFCONT) VALUES ('{line}',{3})";
                        SQLiteCommand insertcommand = new SQLiteCommand(insertstring, connection);
                        insertcommand.ExecuteNonQuery();
                    }
                    break;
                case 4:
                    path = $"D:\\C#\\WorldAtlas\\SouthAmerica.txt";
                    reader = new StreamReader(path);
                    while ((line = reader.ReadLine()) != null)
                    {
                        string insertstring = $"INSERT INTO COUNTRY(COUNTRY,IDOFCONT) VALUES ('{line}',{4})";
                        SQLiteCommand insertcommand = new SQLiteCommand(insertstring, connection);
                        insertcommand.ExecuteNonQuery();
                    }
                    break;
                case 5:
                    path = $"D:\\C#\\WorldAtlas\\Australia.txt";
                    reader = new StreamReader(path);
                    while ((line = reader.ReadLine()) != null)
                    {
                        string insertstring = $"INSERT INTO COUNTRY(COUNTRY,IDOFCONT) VALUES ('{line}',{5})";
                        SQLiteCommand insertcommand = new SQLiteCommand(insertstring, connection);
                        insertcommand.ExecuteNonQuery();
                    }
                    break;
                default:
                    Console.WriteLine("Вы ввели не верный параметр!");
                    break;
            }

           

        }
    }
}
