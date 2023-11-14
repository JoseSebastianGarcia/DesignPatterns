using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Decorator
{
    public class SmsComponent : IComponent
    {
        private IComponent? _component;
        public SmsComponent(IComponent component)
        {
            _component = component;
        }
        public SmsComponent() { }

        public void Send(string message)
        {
            Console.WriteLine($"Sms: {message}");

            if (_component != null)
                _component.Send(message);
        }
    }
}
