using Newtonsoft.Json;
using System.Collections.Generic;

namespace Devino.API.Models
{
    public class Response
    {
        [JsonProperty("result")]
        public Result Result { get; set; }
        [JsonProperty("reasons")]
        public IList<Reason> Reasons { get; set; }
    }
}
