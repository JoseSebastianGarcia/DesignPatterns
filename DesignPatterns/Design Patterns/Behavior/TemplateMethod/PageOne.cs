using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.TemplateMethod
{
    public class PageOne : Template
    {
        protected override void Content()
        {
            Console.WriteLine("PageOne");
            Console.ReadKey();
        }
    }
}
