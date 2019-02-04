using Newtonsoft.Json;

namespace SVOArt.Models
{
    public class Sentence
    {
        [JsonProperty("n")]
        public int Id { get; set; }

        [JsonProperty("s")]
        public string Subject { get; set; }

        [JsonProperty("v")]
        public string Verb { get; set; }

        [JsonProperty("o")]
        public string Object { get; set; }
    }
}
