using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.TemplateMethod
{
    public abstract class Template
    {
        protected abstract void Content();
        public void Render() 
        {
            Console.Clear();
            Content();
        }
    }
}
