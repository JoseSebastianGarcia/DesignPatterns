using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Strategy
{
    public interface IStrategy
    {
        int Calculate(int value, int secondValue);
    }
}
