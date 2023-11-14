using DesignPatterns.Design_Patterns.Behavior.Command;
using DesignPatterns.Design_Patterns.Behavior.Command.Invokers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Views.Design_Patterns.Behavior
{
    public class CommandView : IView
    {
        public void Render()
        {
            Console.Clear();

            CommandHandler handler = new CommandHandler();

            handler.Execute(new CopyCommand());
            handler.Execute(new PasteCommand("Jacinto"));

            Console.ReadKey();
        }
    }
}
