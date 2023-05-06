using Laba4;
using System.Text.Json.Serialization;

namespace Laba_4
{
    public class TableScheme
    {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("columns")]
        public List<Column> Columns { get; }

        public TableScheme(string name, List<Column> columns)
        {
            Name = name;
            Columns = columns;
        }
    }

    public class Column
    {
        [JsonPropertyName("name")]
        public string Name { get; }

        [JsonPropertyName("type")]
        public string Type { get; }

        [JsonPropertyName("isPrimary")]
        public bool IsPrimary { get; }

        public Column(string name, string type, bool isPrimary)
        {
            Name = name;
            Type = type;
            IsPrimary = isPrimary;
        }
    }

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

    public class Row
    {
        public Dictionary<Column, object> Data { get; } = new Dictionary<Column, object>();

        public Row(TableScheme tablescheme, string line)
        {
            string[] columnValues = line.Split(';');

            for (int i = 0; i < columnValues.Length; i++)
            {
                Data.Add(tablescheme.Columns[i], columnValues[i]);
            }
        }
    }
}

