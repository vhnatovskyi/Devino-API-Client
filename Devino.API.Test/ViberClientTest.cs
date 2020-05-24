using Devino.API.Clients;
using Devino.API.Interfaces;
using Devino.API.Messages;
using NUnit.Framework;
using System.Linq;

namespace Devino.API.Test
{
    public class ViberClientTest
    {
        protected IClient Client { get; set; }
        
        [SetUp]
        public void Setup()
        {
            Client = new ViberClient(null);
        }

        [Test]
        public void SendRequest()
        {
            var message = new ViberMessage();
            Assert.IsNotNull(Client.SendMessage(message));
        }

        [Test]
        public void SuccesResponse()
        {
            var response = Client.SendMessage(null);
            Assert.IsTrue(response.Reasons.Count() > 0 || response.Result != null);
        }
    }
}