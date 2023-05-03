using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    public static class InputOutput
    {
        public static string InputExpression()
        {
            string? expr = "";
            Console.Write("Enter expression: ");
            expr = Console.ReadLine();
            while (expr == null ||expr == string.Empty)
            {
                Console.WriteLine("Enter valid expression!");
                expr = Console.ReadLine();
            }
            return expr;
        }
        public static Dictionary<string, double> InputVariables(List<string> vars)
        {
            Dictionary<string, double> parameters = new Dictionary<string, double>();
            double value;
            IEnumerable<string> distinctVars = vars.Distinct();
            foreach (string variable in distinctVars)
            {
                Console.Write(variable + " = ");
                while (! double.TryParse(Console.ReadLine(), out value))
                {
                    Console.WriteLine($"Try again! {variable} = ");
                }
                parameters[variable] = value;
            }
            return parameters;
        }
    }
}
