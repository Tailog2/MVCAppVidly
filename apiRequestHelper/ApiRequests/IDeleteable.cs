using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace RequestsHelper
{
    public interface IDeleteable
    {
        public Task<HttpResponseMessage> Delete(int itemId);
        public Task<HttpResponseMessage> Delete();
    }
}
