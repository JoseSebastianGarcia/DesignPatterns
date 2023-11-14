using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Command
{
    public class CopyCommand : ICommand
    {
        public void Execute()
        {
            string guid = Guid.NewGuid().ToString();
            Clipboard.Set(guid);
            Console.WriteLine($"Mensaje copiado: {guid}");
        }
    }
}
