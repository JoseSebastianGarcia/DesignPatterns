namespace DesignPatterns.Design_Patterns.Behavior.Interpreter
{
    public class AddExpression : IIntegerExpression
    {
        private readonly IIntegerExpression _addingVariable1;
        private readonly IIntegerExpression _addingVariable2;
        public AddExpression(IIntegerExpression addingVariable1, IIntegerExpression addingVariable2) 
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
