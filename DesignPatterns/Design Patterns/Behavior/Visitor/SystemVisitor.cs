using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Visitor
{
    public class SystemVisitor : IVisitor
    {
        public void Visit(WifiAdapter adapter)
        {
            Console.WriteLine($"Wifi serial: {adapter.Serial}");
        }

        public void Visit(SsdDiskAdapter adapter)
        {
            Console.WriteLine($"SSD Disk serial: {adapter.Serial}");
        }
    }
}
