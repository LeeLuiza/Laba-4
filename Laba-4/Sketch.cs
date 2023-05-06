using Laba_4;

namespace Laba4
{
    class Sketch
    {
        public static void Table(Table table, TableScheme tablescheme)
        {
            int max = 0;
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                for (int j = 0; j < tablescheme.Columns.Count - 1; j++)
                {
                    string word = table.Rows[i].Data[tablescheme.Columns[j]].ToString();
                    max = Math.Max(max, word.Length);
                }
            }
            for (int i = 0; i < tablescheme.Columns.Count - 1; i++)
            {
                string word = tablescheme.Columns[i].Name.ToString();
                max = Math.Max(max, word.Length);
            }

            for (int i = 0; i < tablescheme.Columns.Count; i++)
            {
                Console.Write(tablescheme.Columns[i].Name);
                string word = tablescheme.Columns[i].Name
                    ;
                for (int v = 0; v <= (max - word.Length); v++) Console.Write(" ");
            }
            Console.WriteLine();

            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                for (int j = 0; j < tablescheme.Columns.Count; j++)
                {
                    Console.Write(table.Rows[i].Data[tablescheme.Columns[j]]);
                    string word = table.Rows[i].Data[tablescheme.Columns[j]].ToString();
                    for (int v = 0; v <= (max - word.Length); v++) Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}



