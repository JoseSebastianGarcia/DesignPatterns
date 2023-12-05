using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Visitor
{
    public class SsdDiskAdapter : ComponentBase
    {
        public SsdDiskAdapter(string serial) : base(serial)
        {
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
        }
    }
}
