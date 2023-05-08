using Laba4;

namespace Laba_4
{
    public class Table
    {
        public List<Row> Rows { get; } 
        private TableScheme Tablescheme { get; }
        public Table (TableScheme tablescheme, string path)
        {
            Tablescheme = tablescheme;
            Rows = Datarow(path);
        }

        public List<Row> Datarow(string path)
        {
            string[] line = File.ReadAllLines(path); 
            List<Row> rows = new();

            for (int i = 1; i < line.Length; i++)
            {
                if (Checking.Typechecking(Tablescheme, line[i].Split(';'), i))
                {
                    rows.Add(new Row(Tablescheme, line[i]));
                }
            }
            return rows;
        }
    }
}

