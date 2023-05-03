using laba4.Expressions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace laba4
{
    /// <summary>
    ///     Creates Expression from string
    /// </summary>
    public static class ExpressionParser
    {
        public static IExpression CreateExpression(string expression)
        {
            expression = expression.Replace(" ", "");
            try
            {
                return CreateExpressionRecursion(expression, 0, expression.Length - 1);
            }
            catch (ArgumentException) { throw; }
        }
        private static IExpression CreateExpressionRecursion(string str, int firstPos, int lastPos)
        {
            string delims = "/*+-";
            string sub = str.Substring(firstPos, lastPos - firstPos + 1);
            try
            {
                if (sub.IndexOfAny(delims.ToCharArray()) == -1)
                    return CreateSimpleExpression(sub);
                int pos = 0;
                int prior, minPrior = 10;

                for (int i = firstPos; i <= lastPos; i++)
                {
                    switch (str[i])
                    {
                        case '+':
                            prior = 1;
                            break;
                        case '-':
                            prior = 2;
                            break;
                        case '/':
                        case '*':
                            prior = 3;
                            break;
                        default: prior = 10; break;
                    }
                    if (prior < minPrior)
                    {
                        minPrior = prior;
                        pos = i;
                    }
                }
                ComplexExpression expr = new ComplexExpression();
                expr.OperationSign = str[pos];
                expr.LeftExpression = CreateExpressionRecursion(str, firstPos, pos - 1);
                expr.RightExpression = CreateExpressionRecursion(str, pos + 1, lastPos);
                return expr;
            }
            catch (ArgumentException) { throw; }
        }
        private static IExpression CreateSimpleExpression(string expression)
        {
            try
            {
                if (expression == string.Empty)
                    throw new ArgumentException("Expression cannot be processed!");
                int number;
                if (!int.TryParse(expression, out number))
                    return new Variable(expression);
                return new Constant(number);
            }
            catch (ArgumentException) { throw; }
        }
    }
}
