using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;


namespace Math
{
    public static class OneOperatorExpression

    {
        static char[] acceptableCharacters = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9',' ','='};

        public static void resolving(string sign)
        {
            Sentence.OneOperatorInstruction();
            var expression = Console.ReadLine();
            var preparedExpression = OneOperatorExpression.cautingPreparation(expression, sign);
            int result = 0;

            switch (sign)
            {
                case "+":
                    result = adding(preparedExpression);
                    break;
                case "-":
                    result = subtracting(preparedExpression);
                    break;
                case "*":
                    result = multiplicating(preparedExpression);
                    break;
                case "/":
                    result = divisioning(preparedExpression);
                    break;
                default:
                    break;
            }

            Sentence.Outcome(result);
            Option.Menu();
        }

        public static int[] cautingPreparation(string expression, string preSign)
        {
            
            char[] sign = preSign.ToCharArray();

            if (expression.Any(e => !sign.Contains(e) && !acceptableCharacters.Contains(e)))
            {
                Sentence.AlertWrongKey(ConsoleColor.Red);
                return null;
            }
            else
            {
                while (expression.Contains("  "))
                {
                    expression = expression.Replace("  ", " ");
                }
                expression = expression.Replace(" " + preSign+" ", preSign);
                expression = expression.Replace(" "+preSign,preSign);
                expression = expression.Replace(preSign+" ",preSign);
                expression = expression.Trim(' ');
                expression = expression.TrimEnd('=');
                expression = expression.Trim(' ');
                char[] delimiterChars = { ' ', sign[0]};
                int[] preparedExpression = expression.Split(delimiterChars).Select(int.Parse).ToArray();
                return preparedExpression;
            }
        }

        public static int adding(params int[] number)
        {
            
            int result = 0;
            foreach (int n in number)
            {
                result = result + n;
            }
            return result;
        }
        public static int subtracting(params int[] number)
        {
            int result = number[0];
            number = number.Where(w => w != number[0]).ToArray();
            foreach (int n in number)
            {
                result = result - n;
            }
            return result;
        }
        public static int multiplicating(params int[] number)
        {
            int result = 1;
            foreach (int n in number)
            {
                result = result * n;
            }
            return result;
        }
        public static int divisioning(params int[] number)
        {
            try
            {
                int result = number[0];
                number = number.Where(w => w != number[0]).ToArray();
                foreach (int n in number)
                {
                    result = result / n;
                }
                return result;
            }
            catch (Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                LogFile.SaveInFile(e.ToString());
                throw;
            }
        }


    }
}
