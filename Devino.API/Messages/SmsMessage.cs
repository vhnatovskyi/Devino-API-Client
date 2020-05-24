using Devino.API.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Devino.API.Messages
{
    public class SmsMessage : IMessage
    {
        [JsonProperty("from")]
        public string From { get; set; }
        [JsonProperty("to")]
        public string To { get; set; }
        [JsonProperty("text")]
        public string Text { get; set; }
        [JsonProperty("validity")]
        public int Validity { get; set; }
        [JsonProperty("priority")]
        public int Priority { get; set; }
        [JsonProperty("callbackUrl")]
        public string CallbackUrl { get; set; }
        [JsonProperty("options")]
        public IList<object> Options { get; set; }
    }
}
