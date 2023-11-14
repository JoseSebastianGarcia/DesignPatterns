using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Structure.Proxy
{
    public class ThirdPartySubSystem1 : ISayHello
    {
        public string GetHello() => "Hello";
    }
}
