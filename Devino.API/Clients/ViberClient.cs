namespace Devino.API.Clients
{
    public class ViberClient : BaseClient
    {
        public ViberClient(string authToken, string apiUrl = "/viber/messages") : base(authToken, apiUrl) { }
    }
}
