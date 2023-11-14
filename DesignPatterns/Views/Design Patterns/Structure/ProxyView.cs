using DesignPatterns.Design_Patterns.Structure.Proxy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Views;

namespace DesignPatterns.Views.Design_Patterns.Structure
{
    public class ProxyView : IView
    {
        public void Render()
        {
            Console.Clear();

            ThirdPartySubSystem1 s1 = new ThirdPartySubSystem1();
            Console.WriteLine($"Sin proxy: {s1.GetHello()}");

            Console.WriteLine();

            SubSystem1Proxy sp1 = new SubSystem1Proxy(s1);
            Console.WriteLine($"Con proxy: {sp1.GetHello()}");

            Console.ReadKey();
        }
    }
}
