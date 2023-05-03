using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Expressions
{
    public class Constant : IExpression
    {
        private double _number;
        public double Number { 
            get => _number; set => _number = value; }
        public Constant(double number) { _number = number; }
        public string ComposeExpression()
        {
            return _number.ToString();
        }
        public double Calculate(Dictionary<string, double> parameters)
        {
            return _number;
        }
    }
}
