using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Interpreter
{
    public class EqualExpression : IBooleanExpression
    {
        private readonly IIntegerExpression _term1;
        private readonly IIntegerExpression _term2;

        public EqualExpression(IIntegerExpression term1, IIntegerExpression term2) 
        {
            _term1 = term1;
            _term2 = term2;
        }

        public bool Interpret(Context context)
        {
            return _term1.Interpret(context) == _term2.Interpret(context);
        }
    }
}
