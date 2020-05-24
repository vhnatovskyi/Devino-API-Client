namespace Devino.API.Clients
{
    public class SmsClient : BaseClient
    {
        public SmsClient(string authToken, string apiUrl = "/sms/messages") : base(authToken, apiUrl) {}
    }
}
