using System.Text.Json.Serialization;

namespace Laba_4
{
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
}

