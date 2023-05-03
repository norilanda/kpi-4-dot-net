using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Expressions
{
    public class ComplexExpression : IExpression
    {
        public IExpression LeftExpression { get; set; }
        public IExpression RightExpression { get; set; }
        public char OperationSign { get; set; }
        public ComplexExpression(IExpression left, IExpression right, char operationSign)
        {
            LeftExpression = left;
            RightExpression = right;
            OperationSign = operationSign;
        }
        public string ComposeExpression()
        {
            string result = string.Empty;
            result += LeftExpression.ComposeExpression();
            result += OperationSign;
            result += RightExpression.ComposeExpression();
            return result;
        }
        public double Calculate(Dictionary<string, double> parameters)
        {
            try
            {
                double left = LeftExpression.Calculate(parameters);
                double right = RightExpression.Calculate(parameters);
                switch (OperationSign)
                {
                    case '+': return left + right;
                    case '-': return left - right;
                    case '*': return left * right;
                    case '/': return left / right;
                    default: throw new NotImplementedException("Corruped operation sign!");
                }
            }
            catch (FormatException) { throw; }
        }
    }
}
