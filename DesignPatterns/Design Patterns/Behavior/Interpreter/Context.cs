namespace DesignPatterns.Design_Patterns.Behavior.Interpreter
{
    public class Context
    {
        private readonly Dictionary<string, int> _variables = new Dictionary<string, int>();
        
        public Context AddVariable(string name, int value) 
        {
            if(!_variables.ContainsKey(name))
                _variables.Add(name, value);

            return this;
        }
        public int GetVariable(string name) 
        {
            return _variables[name]; 
        }
    }
}
