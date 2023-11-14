using DesignPatterns.Views.Design_Patterns.Structure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Views;
using DesignPatterns.Views.Design_Patterns;

namespace DesignPatterns.Views
{
    public class StructureView : IView
    {
        private readonly IView _previous;
        public StructureView(IView previous) 
        {
            _previous = previous;
        }
        public void Render()
        {
            Console.Clear();

            Console.WriteLine("==========================");
            Console.WriteLine("1. Decorator");
            Console.WriteLine("2. Proxy");
            Console.WriteLine("3. Facade");
            Console.WriteLine("9. Volver");
            Console.WriteLine("==========================");
            Console.Write("Seleccione una opción: ");
            var key = Console.ReadKey();

            IView view;
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        view = new DecoratorView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D2:
                    {
                        view = new ProxyView();
                        view.Render();

                        this.Render();
                        break;
                    }
                case ConsoleKey.D3:
                    {
                        view = new FacadeView();
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
