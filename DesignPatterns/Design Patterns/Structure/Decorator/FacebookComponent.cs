using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Decorator
{
    public class FacebookComponent : IComponent
    {
        private IComponent? _component;
        public FacebookComponent(IComponent component)
        {
            _component = component;
        }
        public FacebookComponent() { }
        public void Send(string message)
        {
            Console.WriteLine($"Facebook: {message}");

            //Esta pequeña porción de código es
            //la que diferencia el patron Decorador del Proxy
            if (_component != null) 
                _component.Send(message);
        }
    }
}
