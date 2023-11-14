using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Design_Patterns.Behavior.Strategy
{
    public class StrategyContext
    {
        private IStrategy _strategy = null!;
        
        public StrategyContext() 
        {
        
        }
        public StrategyContext(IStrategy strategy) 
        {
            _strategy = strategy;
        }

        public void SetStrategy(IStrategy strategy) 
        {
            _strategy = strategy;
        }

        public int Calculate(int value, int secondValue)
            => _strategy.Calculate(value, secondValue);
    }
}
