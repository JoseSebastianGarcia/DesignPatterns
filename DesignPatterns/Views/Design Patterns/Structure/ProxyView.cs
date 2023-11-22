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

            SystemSayHello s1 = new SystemSayHello();
            Console.WriteLine($"Sin proxy: {s1.GetHello()}");

            Console.WriteLine();

            SystemSayHelloProxy sp1 = new SystemSayHelloProxy(s1);
            Console.WriteLine($"Con proxy: {sp1.GetHello()}");

            Console.ReadKey();
        }
    }
}
