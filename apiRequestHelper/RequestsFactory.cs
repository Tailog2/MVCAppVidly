using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestsHelper
{
    public class RequestsFactory
    {
        public static IApiRequest CreateApiRequest(string url)
        {
            return new ApiRequest(url);
        }
    }
}
