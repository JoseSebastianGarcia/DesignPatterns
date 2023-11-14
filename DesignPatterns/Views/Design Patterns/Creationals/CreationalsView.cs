using DesignPatterns.Views.Design_Patterns.Creationals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Views;
using DesignPatterns.Views.Design_Patterns;

namespace DesignPatterns.Views
{
    public class CreationalsView : IView
    {
        private readonly IView _previous;
        public CreationalsView(IView previous)
        {
            _previous = previous;
        }
        public void Render()
        {
            Console.Clear();

            Console.WriteLine("==========================");
            Console.WriteLine("1. Singleton");
            Console.WriteLine("2. Prototype");
            Console.WriteLine("3. Builder");
            Console.WriteLine("9. Volver");
            Console.WriteLine("==========================");
            Console.Write("Seleccione una opción: ");
            var key = Console.ReadKey();

            IView view;
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        view = new SingletonView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        view = new PrototypeView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        view = new BuilderView();
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
