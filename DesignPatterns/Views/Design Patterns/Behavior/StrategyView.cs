using DesignPatterns.Design_Patterns.Behavior.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Views.Design_Patterns.Behavior
{
    public class StrategyView : IView
    {
        public void Render()
        {
            Console.Clear();

            StrategyContext context = new StrategyContext();

            Console.WriteLine("Seteo estrategia de suma");
            context.SetStrategy(new AdditionStrategy());
            int result = context.Calculate(10, 11);
            Console.WriteLine($"10 + 11 = {result}");

            Console.WriteLine("Seteo estrategia de resta");
            context.SetStrategy(new SubstractionStrategy());
            result = context.Calculate(11, 10);
            Console.WriteLine($"11 - 10 = {result}");

            Console.ReadKey();
        }
    }
}
