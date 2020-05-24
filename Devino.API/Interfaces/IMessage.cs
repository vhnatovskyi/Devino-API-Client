using System.Collections.Generic;

namespace Devino.API.Interfaces
{
    public interface IMessage
    {
        public string From { get; set; }
        public string To { get; set; }
        public string Text { get; set; }
        public int Validity { get; set; }
        public int Priority { get; set; }
        public string CallbackUrl { get; set; }
        public IList<object> Options { get; set; }
    }
}
