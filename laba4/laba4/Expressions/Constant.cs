using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Expressions
{
    /// <summary>
    ///     Represents a constant (number) in expression
    /// </summary>
    public class Constant : IExpression
    {
        private double _number;
        public double Number { 
            get => _number; set => _number = value; }
        public Constant(double number) { _number = number; }
        
        // returns constant as a string
        public string ComposeExpression()
        {
            return _number.ToString();
        }

        // returns number
        public double Calculate(Dictionary<string, double> parameters)
        {
            return _number;
        }
        
        // constant is not a variable, so it does not do anything with vars list
        // this method exists because Constant implements IExpression interface
        public void GetAllVariables(ref List<string> vars) { }
    }
}
