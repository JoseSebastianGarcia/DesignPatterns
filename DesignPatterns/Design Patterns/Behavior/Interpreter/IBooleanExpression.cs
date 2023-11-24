using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Interpreter
{
    public interface IBooleanExpression
    {
        bool Interpret(Context context);
    }
}
