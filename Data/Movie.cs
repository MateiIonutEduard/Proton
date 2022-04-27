using System.Text.Json.Serialization;

namespace Proton.Data
{
    public class Movie
    {
        public string Id { get; set; }
        [JsonPropertyName("year")]
        public int Year { get; set; }
        [JsonPropertyName("title"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string Title { get; set; }
        [JsonPropertyName("info"), JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public MovieInfo Info { get; set; }
    }
}
