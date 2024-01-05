using DesignPatterns.Design_Patterns.Behavior.TemplateMethod;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Views.Design_Patterns.Behavior
{
    public class TemplateMethodView : IView
    {
        public void Render()
        {
            Console.Clear();

            Template template; 
            
            template = new PageOne();
            template.Render();

            template = new PageTwo();
            template.Render();


            Console.ReadKey();
        }
    }
}
