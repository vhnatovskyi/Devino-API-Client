using Devino.API.Interfaces;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Devino.API.Models
{
    public class Request
    {
        [JsonProperty("messages")]
        public IList<IMessage> Messages { get; set; }
    }
}
