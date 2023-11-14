using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Views;
using DesignPatterns.Views.Design_Patterns;

namespace DesignPatterns.Views
{
    public class CategoriesView : IView
    {
        public void Render()
        {
            Console.Clear();

            Console.WriteLine("=============================");
            Console.WriteLine("1. Patrones creacionales");
            Console.WriteLine("2. Patrones estructurales");
            Console.WriteLine("3. Patrones de comportamiento");
            Console.WriteLine("9. Salir");
            Console.WriteLine("=============================");
            Console.Write("Seleccione una opción: ");
            var key = Console.ReadKey();

            IView view;
            switch (key.Key)
            {
                case ConsoleKey.D1:
                    {
                        view = new CreationalsView(this);
                        view.Render();

                        break;
                    }
                case ConsoleKey.D2:
                    {
                        view = new StructureView(this);
                        view.Render();

                        break;
                    }
                case ConsoleKey.D3:
                    {
                        view = new BehaviorView(this);
                        view.Render();

                        break;
                    }
                
                case ConsoleKey.D9:
                    {
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
