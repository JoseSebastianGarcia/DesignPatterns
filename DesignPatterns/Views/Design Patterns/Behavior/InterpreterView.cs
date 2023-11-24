using DesignPatterns.Design_Patterns.Behavior.Interpreter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Views.Design_Patterns.Behavior
{
    public class InterpreterView : IView
    {
        public void Render()
        {
            Console.Clear();

            AddExpression expression = new AddExpression(
                new AddExpression(
                    new VariableExpression("number1"), 
                    new VariableExpression("number2")), 
                new VariableExpression("number3"));

            Context context = new Context();
            context.AddVariable("number1", 10);
            context.AddVariable("number2", 9);
            context.AddVariable("number3", 15);

            int result = expression.Interpret(context);

            Console.WriteLine($"Y el resultado de '(10 + 9) + 15' es ({result} == 34).");

            Console.ReadKey();
        }
    }
}
