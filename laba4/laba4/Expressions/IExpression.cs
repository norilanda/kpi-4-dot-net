using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Expressions
{
    /// <summary>
    ///     Expression interface
    /// </summary>
    public interface IExpression
    {
        // combines all parts of expression to a single string
        public string ComposeExpression();
        // calculates the expression result, all variables are substituted with parameters
        public double Calculate(Dictionary<string, double> parameters);
        // gathers all variables avaliable in expression
        public void GetAllVariables(ref List<string> vars);
    }
}
