using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Program
    {
        Calculator C = new Calculator();
  

  
        static string expression = "2+(3*(2 + 4 * 2 - 8/2))+8";
        static char[] operators = { '*', '/', '+', '-'};
        static char[] acceptableCharacters = {'0','1','2','3','4','5','6','7','8','9','(',')'}; //what with coma?

        static void Main(string[] args)
        {
            LogFile.CreateFile();
            Sentence.Start();
            var ciag = Console.ReadKey();

            expression = expression.Replace(" ", "");
            expression = expression.TrimEnd('=');

            if (expression.Any(e => !operators.Contains(e) && !acceptableCharacters.Contains(e)))
            {
                Sentence.AlertWrongKey(ConsoleColor.Red);
            }
            else
            {
                Calculator.SeparateAndCountBacket(expression, operators);
            }

            Console.WriteLine(expression.ToString());
            Console.ReadKey();


        }

        


    }


}
