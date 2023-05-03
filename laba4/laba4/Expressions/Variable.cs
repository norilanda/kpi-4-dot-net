using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Expressions
{
    public class Variable : IExpression
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public Variable(string name)
        {
            _name = name;
        }
        public string ComposeExpression()
        {
            return _name;
        }
        public double Calculate(Dictionary<string, double> parameters)
        {
            if (!parameters.ContainsKey(_name))
                throw new FormatException($"Variable {_name} has no value!");
            return parameters[_name];
        }
    }
}
