using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Visitor
{
    public interface IVisitor
    {
        void Visit(WifiAdapter adapter);
        void Visit(SsdDiskAdapter adapter);
    }
}
