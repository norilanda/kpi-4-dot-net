using laba4.Expressions;

namespace laba4
{
//  7) Реалізувати дерево розбору виразу, заданого наведеними нижче синтаксичними правилами:
//  <вираз>::=<простий вираз> | <складний вираз>
//  <простий вираз>::=<константа> | <змінна>
//  <константа>::=(<число>)
//  <змінна>::=(<ім'я>)
//  <складний вираз>::=(<вираз><знак операції><вираз>)
//  <знак операції>::=+|-|*|/
    internal class Program
    {
        static void Main(string[] args)
        {
            // inputting the expression as a string
            string str = InputOutput.InputExpression();
            try
            {
                // parsing string to expression
                IExpression expr = ExpressionParser.CreateExpression(str);
                // getting all variables avaliable in expression
                List<string> vars = new List<string>();
                expr.GetAllVariables(ref vars);
                if (vars.Count > 0)
                {
                    Console.WriteLine("Enter all variables:");
                }
                Dictionary<string, double> parameters = InputOutput.InputVariables(vars);

                // getting expression as a string
                string composedExpression = expr.ComposeExpression();
                Console.WriteLine($"Entered expression: {composedExpression}");
                // calculate the result of expression using inputed variables
                double exprResult = expr.Calculate(parameters);
                Console.WriteLine($"The result of this expression = {exprResult}");
            } 
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}