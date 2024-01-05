namespace DesignPatterns.Design_Patterns.Creationals.FluentApi
{
    public class Calculator
    {
        private decimal _value;
        private Calculator(decimal value)
        {
            _value = value;
        }
        public static Calculator Create(decimal value)
        {
            Console.WriteLine($"Empiezo en {value}");
            return new Calculator(value);
        }
        public Calculator SetValue(decimal value)
        {
            Console.WriteLine($"Reemplazo {_value} por {value}");
            _value = value;
            return this;
        }

        public Calculator Add(decimal value)
        {
            Console.Write($"{_value} + {value} = ");
            _value += value;
            Console.WriteLine($"{_value}");
            return this;
        }
        public Calculator Subtract(decimal value)
        {
            Console.Write($"{_value} - {value} = ");
            _value -= value;
            Console.WriteLine($"{_value}");
            return this;
        }
        public Calculator Multiply(decimal value)
        {
            Console.Write($"{_value} * {value} = ");
            _value *= value;
            Console.WriteLine($"{_value}");
            return this;
        }
        public Calculator Divide(decimal value)
        {
            Console.Write($"{_value} / {value} = ");
            _value /= value;
            Console.WriteLine($"{_value}");
            return this;
        }

        public void Display(Action<decimal> format)
        {
            Console.WriteLine();
            format(_value);
            Console.ReadKey();
        }
    }
}
