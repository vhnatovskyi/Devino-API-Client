using Newtonsoft.Json;

namespace Devino.API.Models
{
    public class Result
    {
        [JsonProperty("code")]
        public string Code { get; set; }
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
    }
}
