using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Chain_of_Responsibility
{
    internal class ParrotLink : Link
    {
        public override void Handle(string command)
        {
            if (command == "papa") 
            {
                Console.WriteLine("Soy el loro: rica papa");
            }

            Next(command);
        }
    }
}
