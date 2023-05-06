using System;
using Laba_4;
using System.Text.Json;

namespace Laba4
{
    class Program
    {
        static void Main()
        {
            string[,] file = new string[,] { { "Book.json", "Book.csv" }, { "Reader.json", "Reader.csv" } };
            Console.WriteLine("Введите какую базу данных считать\n" + "1. Book\n" + "2. Reader");
            int database = int.Parse(Console.ReadLine())-1;

            Console.WriteLine();
            TableScheme tablescheme = JsonSerializer.Deserialize<TableScheme>(File.ReadAllText(file[database, 0]));
            string path = file[database, 1];
            Table table = new(tablescheme, path);

            Sketch.Table(table, tablescheme);
        }
    }
}



