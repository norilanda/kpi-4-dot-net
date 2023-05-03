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
            string str = "4+x-9";
            try
            {
                IExpression expr = ExpressionParser.CreateExpression(str);
                List<string> vars = new List<string>();
                expr.GetAllVariables(ref vars);
                Console.WriteLine("Enter all variables:");
                Dictionary<string, double> parameters = InputOutput.InputVariables(vars);

                string composedExpression = expr.ComposeExpression();
                Console.WriteLine($"Entered expression: {composedExpression}");
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