using Devino.API.Clients;
using Devino.API.Interfaces;
using Devino.API.Messages;
using NUnit.Framework;
using System.Linq;

namespace Devino.API.Test
{
    public class SmsClientTest
    {
        protected IClient Client { get; set; }
        
        [SetUp]
        public void Setup()
        {
            Client = new SmsClient(null);
        }

        [Test]
        public void SendRequest()
        {
            var message = new SmsMessage();
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