namespace DesignPatterns.Design_Patterns.Behavior.Interpreter
{
    public class VariableExpression : IExpression
    {
        private readonly string _variable;
        public int Interpret(Context context)
        {
            return context.GetVariable(_variable);
        }

        public VariableExpression(string variable) 
        {
            _variable = variable;
        }
    }
}
