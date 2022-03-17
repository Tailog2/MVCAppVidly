using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RequestsHelper
{
    public class ApiRequest : IApiRequest
    {
        private string _url;
        private HttpClient _httpClient;

        public ApiRequest(string url)
        {
            _url = url;
            HttpClient _httpClient = new HttpClient();
        }

        public Task<HttpResponseMessage> Delete(int itemId)
        {
            if (_url.Last() == '/')
                return _httpClient.DeleteAsync(_url + itemId);

            return _httpClient.DeleteAsync(_url + "/" + itemId);
        }

        public Task<HttpResponseMessage> Delete()
        {
            throw new NotImplementedException();
        }

        public string Get(int itemId)
        {
            throw new NotImplementedException();
        }

        public string Get()
        {
            throw new NotImplementedException();
        }
    }
}
