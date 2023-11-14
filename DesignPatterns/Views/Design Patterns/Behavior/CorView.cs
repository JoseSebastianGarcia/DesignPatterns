using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Design_Patterns.Chain_of_Responsibility;

namespace DesignPatterns.Views
{
    public class CorView : IView
    {
        public void Render()
        {
            Console.Clear();
            ChainHandler chain = new ChainHandler();
            chain.AddLink(new DogLink());
            chain.AddLink(new MonkeyLink());
            chain.AddLink(new ParrotLink());

            string[] commands = new string[] {
                "banana",
                "papa",
                "hueso"
            };

            foreach (string command in commands)
            {
                Console.WriteLine($"¿Quien quiere un/a {command}?");
                chain.Execute(command);
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
