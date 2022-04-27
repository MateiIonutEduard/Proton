using System;
using System.Text.Json.Serialization;
#pragma warning disable

namespace Proton.Data
{
    public class MovieInfo
    {
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string[] directors { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public DateTime release_date { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public double rating { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string[] genres { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string image_url { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string plot { get; set; }
        [JsonPropertyName("rank")]
        public int Rank { get; set; }
        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public int? running_time_secs { get; set; }

        [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
        public string[] actors { get; set; }
    }
}
