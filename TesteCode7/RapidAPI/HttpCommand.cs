using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TesteCode7.RapidAPI
{
    public class HttpCommand
    {
        private const string URI = "https://numbersapi.p.rapidapi.com/";

        private async Task<string> GetHttpRequestMessage(string complementURI)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage();

            SetHttpHeaders(client);
            request.RequestUri = new Uri(URI + complementURI);

            try 
            {
                var response = client.GetAsync(request.RequestUri).Result;
                return await response.Content.ReadAsStringAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private HttpResponseMessage GetHttpRequestResponse(string complementURI, bool isAuthorized)
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage();

            if (isAuthorized)
                SetHttpHeaders(client);

            request.RequestUri = new Uri(URI + complementURI);

            try
            {
                return client.GetAsync(request.RequestUri).Result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public void SetHttpHeaders(HttpClient client)
        {
            client.DefaultRequestHeaders.Add("x-rapidapi-host", "numbersapi.p.rapidapi.com");
            client.DefaultRequestHeaders.Add("x-rapidapi-key", "5febd1b545mshafa32c3e7eb2730p1e7e38jsn40886a16e180");
        }

        public async Task<string> GetHttpRequestMessageContent(string complementURI)
        {
            var httpCommand = new HttpCommand();
            return await httpCommand.GetHttpRequestMessage(complementURI);
        }

        public HttpResponseMessage GetHttpRequestResponseContent(string complementURI, bool isAuthorized)
        {
            var httpCommand = new HttpCommand();
            return httpCommand.GetHttpRequestResponse(complementURI, isAuthorized);
        }
    }
}
