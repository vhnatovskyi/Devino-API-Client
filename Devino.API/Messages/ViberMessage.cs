using Newtonsoft.Json;

namespace Devino.API.Messages
{
    public class ViberMessage : SmsMessage
    {
        [JsonProperty("image")]
        public string Image { get; set; }
        [JsonProperty("action")]
        public string Action { get; set; }
        [JsonProperty("caption")]
        public string Caption { get; set; }
        [JsonProperty("scheduledTime")]
        public string ScheduledTime { get; set; }
    }
}
