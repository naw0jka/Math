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
        Sentence S = new Sentence();


       // Sentence.Start();
       //Console.Read()

        static string expression = "2+(3*(2 + 4 * 2 - 28/2))+8"; //Console.Read()
        static char[] operators = { '+', '-', '*', '/' };

        static void Main(string[] args)
        {
            expression = expression.Replace(" ", "");

            if (expression.Any(e => !operators.Contains(e) || !char.IsDigit(e)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("You miss the key. Try one more time");
                Console.ResetColor();
            }
            else
            {
                Calculator.CalculatorInBrackets(expression, operators);
            }


            Console.ReadKey();


        }

        


    }


}
