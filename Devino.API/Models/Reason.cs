using Newtonsoft.Json;

namespace Devino.API.Models
{
    public class Reason
    {
        [JsonProperty("key")]
        public string Key { get; set; }
        [JsonProperty("ref")]
        public string Ref { get; set; }
    }
}
