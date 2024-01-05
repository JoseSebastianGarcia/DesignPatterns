using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using DesignPatterns.Views;
using DesignPatterns.Views.Design_Patterns;
using DesignPatterns.Views.Design_Patterns.Behavior;

namespace DesignPatterns.Views
{
    public class BehaviorView : IView
    {
        private readonly IView _previous;
        public BehaviorView(IView previous)
        {
            _previous = previous;
        }
        public void Render()
        {
            Console.Clear();

            Console.WriteLine("==========================");
            Console.WriteLine("1. Chain of Responsibility");
            Console.WriteLine("2. Strategy");
            Console.WriteLine("3. Command");
            Console.WriteLine("4. Interpreter");
            Console.WriteLine("5. Visitor");
            Console.WriteLine("6. Template Method");
            Console.WriteLine("9. Volver");
            Console.WriteLine("==========================");
            Console.Write("Seleccione una opción: ");
            var key = Console.ReadKey();

            IView view;
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        view = new CorView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        view = new StrategyView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        view = new CommandView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D4:
                    {
                        view = new InterpreterView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D5:
                    {
                        view = new VisitorView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D6:
                    {
                        view = new TemplateMethodView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D9:
                    {
                        _previous.Render();

                        break;
                    }
                default:
                    {
                        this.Render();
                        break;
                    }
            }
        }
    }
}
