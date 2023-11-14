using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Chain_of_Responsibility
{
    public class DogLink : Link
    {
        public override void Handle(string command)
        {
            if (command == "hueso") 
            {
                Console.WriteLine("Soy el perro: Dame mi hueso");
            }

            Next(command);
        }
    }
}
