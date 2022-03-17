using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RequestsHelper
{
    public interface IGetable
    {
        public string Get(int itemId);
        public string Get();
    }
}
