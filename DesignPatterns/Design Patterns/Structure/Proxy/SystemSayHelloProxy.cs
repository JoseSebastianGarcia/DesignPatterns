using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Structure.Proxy
{
    public class SystemSayHelloProxy : ISayHello
    {
        private readonly SystemSayHello _subSystem1;
        public SystemSayHelloProxy(SystemSayHello subSystem1) 
        {
            _subSystem1 = subSystem1;
        }

        public string GetHello()
        {
            return _subSystem1.GetHello() + " world!";
        }
    }
}
