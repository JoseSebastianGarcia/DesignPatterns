namespace DesignPatterns.Design_Patterns.Behavior.Interpreter
{
    public interface IExpression
    {
        int Interpret(Context context);
    }
}
