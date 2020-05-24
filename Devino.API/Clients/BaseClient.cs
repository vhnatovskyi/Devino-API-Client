using Devino.API.Interfaces;
using Devino.API.Models;
using Newtonsoft.Json;
using System.IO;
using System.Net;

namespace Devino.API.Clients
{
    public abstract class BaseClient : IClient
    {
        protected string Token { get; }
        protected string BaseURL { get; set; } = "https://api.devino.online";

        /// <summary>
        /// Base constructor
        /// </summary>
        /// <param name="authToken">API key or Basic authorize login and password in Base64</param>
        /// <param name="apiUrl">API method url</param>
        public BaseClient(string authToken, string apiUrl)
        {
            Token = authToken;
            BaseURL += apiUrl;
        }

        /// <summary>
        /// Send message for provider
        /// </summary>
        /// <param name="message">Model message</param>
        /// <returns>Feedback from provider</returns>
        public virtual Response SendMessage(IMessage message)
        {
            var request = BuildRequest(message);
            var response = SendRequest(request);
            return response;
        }

        /// <summary>
        /// Build request from provider
        /// </summary>
        /// <param name="message">Model message</param>
        /// <returns>Return HttpWebRequest</returns>
        protected virtual HttpWebRequest BuildRequest(IMessage message)
        {
            HttpWebRequest request = (HttpWebRequest)HttpWebRequest.Create(BaseURL);
            request.Method = "POST";
            request.Headers.Add("Authorization", Token);
            request.ContentType = "application/json";
            using StreamWriter streamWriter = new StreamWriter(request.GetRequestStream());
            string body = JsonConvert.SerializeObject(message);
            streamWriter.Write(body);
            
            return request;
        }

        /// <summary>
        /// Send request from provider
        /// </summary>
        /// <param name="request">Request settings</param>
        /// <returns>Feedback from provider</returns>
        protected virtual Response SendRequest(HttpWebRequest request)
        {
            try
            {
                using HttpWebResponse httpResponse = (HttpWebResponse)request.GetResponse();
                using StreamReader streamReader = new StreamReader(httpResponse.GetResponseStream());
                return JsonConvert.DeserializeObject<Response>(streamReader.ReadToEnd());
            }
            catch (WebException exception)
            {
                return BuildResponse(exception);
            }
        }

        private Response BuildResponse(WebException exception)
        {
            using Stream stream = exception.Response.GetResponseStream();
            using StreamReader reader = new StreamReader(stream);
            return JsonConvert.DeserializeObject<Response>(reader.ReadToEnd());
        }
    }
}
