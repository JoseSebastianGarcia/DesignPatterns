using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Decorator
{
    public class SlackComponent : IComponent
    {
        private IComponent? _component;
        public SlackComponent(IComponent component)
        {
            _component = component;
        }
        public SlackComponent() { }
        public void Send(string message)
        {
            Console.WriteLine($"Slack: {message}");

            if (_component != null)
                _component.Send(message);
        }
    }
}
