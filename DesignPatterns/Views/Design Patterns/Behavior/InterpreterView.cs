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


            IBooleanExpression expression = new AndExpression(
                    new EqualExpression(
                            new AddExpression(
                                new VariableExpression("number1"),
                                new VariableExpression("number2")
                                ),
                            new VariableExpression("number3")),
                    new EqualExpression(
                            new VariableExpression("number4"),
                            new VariableExpression("number5")));

            Context context = new Context();
            context
                .AddVariable("number1", 10)
                .AddVariable("number2", 9)
                .AddVariable("number3", 19)
                .AddVariable("number4", 100)
                .AddVariable("number5", 100);

            bool result = expression.Interpret(context);

            Console.WriteLine($" (10+9) == 19 y 100 == 100 debería ser True y es {result}.");

            Console.ReadKey();
        }
    }
}
