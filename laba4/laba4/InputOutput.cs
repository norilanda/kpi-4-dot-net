using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4
{
    /// <summary>
    ///     inputs and outputs information
    /// </summary>
    public static class InputOutput
    {
        // inputs expression
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

        // inputs all necessary variables and returns dictionary with their values
        public static Dictionary<string, double> InputVariables(List<string> vars)
        {
            Dictionary<string, double> parameters = new Dictionary<string, double>();
            if (vars.Count == 0)
                return parameters;
            double value;
            IEnumerable<string> distinctVars = vars.Distinct();
            foreach (string variable in distinctVars)
            {
                Console.Write(variable + " = ");
                while (! double.TryParse(Console.ReadLine(), out value))
                {
                    Console.Write($"Try again! {variable} = ");
                }
                parameters[variable] = value;
            }
            return parameters;
        }
    }
}
