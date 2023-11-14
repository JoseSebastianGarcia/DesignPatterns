using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Chain_of_Responsibility
{
    public class MonkeyLink : Link
    {
        public override void Handle(string command)
        {
            if (command == "banana")
            {
                Console.WriteLine("Soy el mono: Dame mi banana");
            }

            Next(command);
        }
    }
}
