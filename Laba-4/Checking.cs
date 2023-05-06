using Laba_4;

namespace Laba4
{
    class Checking
    {
        public static bool Typechecking(TableScheme Tablescheme, string[] line, int row)
        {
            if (Tablescheme.Columns.Count != line.Length)
            {
                Console.WriteLine($"Количество столбцов не совпадает с необходимым количеством в {row} строке");
                return false;
            }
            bool correct = true;
            for (int i = 0; i < line.Length; i++)
            {
                switch (Tablescheme.Columns[i].Type)
                {
                    case "int":
                        if (!int.TryParse(line[i], out int _))
                        {
                            Console.WriteLine($"Данные не совпадают в {row} строке {i+1} столбце.");
                            correct = false;
                        }
                        break;
                    case "float":
                        if (!float.TryParse(line[i], out float _))
                        {
                            Console.WriteLine($"Данные не совпадают в {row} строке {i + 1} столбце.");
                            correct = false;
                        }
                        break;
                    case "double":
                        if (!double.TryParse(line[i], out double _))
                        {
                            Console.WriteLine($"Данные не совпадают в {row} строке {i + 1} столбце.");
                            correct = false;
                        }
                        break;
                    case "bool":
                        if (!bool.TryParse(line[i], out bool _))
                        {
                            Console.WriteLine($"Данные не совпадают в {row} строке {i + 1} столбце.");
                            correct = false;
                        }
                        break;
                    case "dateTime":
                        if (!DateTime.TryParse(line[i], out DateTime _))
                        {
                            Console.WriteLine($"Данные не совпадают в {row} строке {i + 1} столбце.");
                            correct = false;
                        }
                        break;
                }
            }
            return correct;
        }
    }
}



