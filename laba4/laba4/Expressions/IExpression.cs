using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4.Expressions
{
    public interface IExpression
    {
        public string ComposeExpression();
        public double Calculate(Dictionary<string, double> parameters);
    }
}
