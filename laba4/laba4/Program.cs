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
            Dictionary<string,double> parameters = new Dictionary<string,double>();
            parameters["x"] = 1;
            try
            {
                IExpression expr = ExpressionParser.CreateExpression(str);
                List<string> vars = new List<string>();
                expr.GetAllVariables(ref vars);
                string composedExpression = expr.ComposeExpression();
                double exprResult = expr.Calculate(parameters);
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