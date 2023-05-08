using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Expressions
{
    /// <summary>
    ///     Represents a variable (name of variable) in expression
    /// </summary>
    public class Variable : IExpression
    {
        private string _name;
        public string Name { get => _name; set => _name = value; }
        public Variable(string name)
        {
            _name = name;
        }

        // returns variable name
        public string ComposeExpression()
        {
            return _name;
        }

        // substitutes variable with its values, passed in parameters dictionary.
        // if variable cannot be found in parameters - throws an exception
        public double Calculate(Dictionary<string, double> parameters)
        {
            if (!parameters.ContainsKey(_name))
                throw new FormatException($"Variable {_name} has no value!");
            return parameters[_name];
        }

        // adds current variable name to list
        public void GetAllVariables(ref List<string> vars)
        {
            vars.Add(_name);
        }

    }
}
