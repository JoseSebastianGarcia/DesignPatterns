using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.Design_Patterns.Singleton;

namespace DesignPatterns.Views.Design_Patterns
{
    public class SingletonView : IView
    {
        public void Render()
        {
            Console.Clear();

            MessageContext objectA = MessageContext.GetInstance();
            Console.WriteLine($"Primer objeto: {objectA.Message()}");

            MessageContext objectB = MessageContext.GetInstance();
            Console.WriteLine($"Segundo objeto: {objectB.Message()}");

            
            Console.WriteLine($"Ambos objetos muestran lo mismo, ¿pero son identicos?: {(objectA == objectB ? "SI" : "NO")}");

            Console.ReadKey();
        }
    }
}
