using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Command.Invokers
{
    public class CommandHandler
    {
        public void Execute(ICommand command) 
        {
            command.Execute();
        }
    }
}
