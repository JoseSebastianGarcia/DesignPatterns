namespace DesignPatterns.Design_Patterns.Behavior.Interpreter
{
    public class AddExpression : IExpression
    {
        private readonly IExpression _addingVariable1;
        private readonly IExpression _addingVariable2;
        public AddExpression(IExpression addingVariable1, IExpression addingVariable2) 
        {   
            _addingVariable1 = addingVariable1;
            _addingVariable2 = addingVariable2;
        }
        public int Interpret(Context context)
        {
            return _addingVariable1.Interpret(context) + _addingVariable2.Interpret(context);
        }
    }
}
