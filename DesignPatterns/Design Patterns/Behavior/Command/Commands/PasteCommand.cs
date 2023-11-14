using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Command
{
    public class PasteCommand : ICommand
    {
        private readonly string _name;
        public PasteCommand(string name) 
        {
            _name = name;
        }
        public void Execute()
        {
            string copiedMessage = Clipboard.Get();
            
            Console.WriteLine();
            Console.WriteLine($"Mensaje pegado: {copiedMessage}");
            Console.WriteLine($"Parámetro recibido: {_name}");
        }
    }
}
