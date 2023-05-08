namespace Laba_4
{
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

