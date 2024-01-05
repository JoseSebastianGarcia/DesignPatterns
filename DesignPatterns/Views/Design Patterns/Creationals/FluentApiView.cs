using DesignPatterns.Design_Patterns.Creationals.FluentApi;

namespace DesignPatterns.Views.Design_Patterns.Creationals
{
    public class FluentApiView : IView
    {
        public void Render()
        {
            Console.Clear();

            Calculator
                .Create(10)
                .SetValue(50)
                .Multiply(2)
                .Add(10)
                .Divide(10)
                .Subtract(5)
                .Display((value) => {
                    Console.WriteLine($"Total: {value}");
                });


            Console.ReadKey();
        }
    }
}
