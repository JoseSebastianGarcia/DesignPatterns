using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Visitor
{
    public abstract class ComponentBase : IVisitable
    {
        private readonly string _serial;
        public ComponentBase(string serial)
        {
            _serial = serial;
        }
        public string Serial { get => _serial; }

        public abstract void Accept(IVisitor visitor);
    }
}
