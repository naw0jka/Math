using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Math
{
    class Calculator
    {
        public static void SeparateAndCountBacket(string expression, char[] operators)
        {
            var endIndex = expression.IndexOf(")");
            if (endIndex > -1)
            {
                var startIndex = -1;
                var start = 0;
                var count = 0;
                var index = 0;
                while ((start <= endIndex) && (index > -1))
                {
                    count = endIndex - start;
                    index = expression.IndexOf("(", start, count);
                    if (index == -1) break;
                    startIndex = index;
                    start = index + 1;
                }
                var inBrakets = expression.Substring(startIndex, (endIndex - startIndex + 1));
                //inBrakets = inBrakets.Replace("+-", "-");
                //inBrakets = inBrakets.Replace("--", "-");
                //what with '*-'
                //what with '/-'

                var withoutBrakets = inBrakets.Trim('(', ')');
                var values = withoutBrakets.Split(operators);
                var valuesAmount = values.Length;
                
                foreach (char c in operators)
                {
                    withoutBrakets = CalculateExpressionInBracket(withoutBrakets, values, valuesAmount, operators, c.ToString());
                    values = withoutBrakets.Split(operators);
                }

                // expression = expression.Replace()


            }
        }



        private static string CalculateExpressionInBracket(string withoutBraketsParametr, string[] values, int valuesAmount, char[] operators, string sign)
        {
            var index = withoutBraketsParametr.IndexOf(sign);
            var PreviousValueIndex = -2;
            var PreviousValue = -1;
            var Separator = 1;

            if (index > -1)
            {

                while (PreviousValueIndex < (index - 1))
                {

                    PreviousValue++;

                    var number = values[PreviousValue].ToString().Length;
                    PreviousValueIndex = PreviousValueIndex + number + Separator;

                }
                int a = int.Parse(values[PreviousValue]);
                int b = int.Parse(values[PreviousValue + 1]);
                int result = CauntExpressionWithTwoNumbers(a, b, sign);
                string oldResult = a.ToString() + sign + b.ToString();
                return withoutBraketsParametr = withoutBraketsParametr.Replace(oldResult, result.ToString());
            }
            else
            {
                return withoutBraketsParametr;
            }

        }

        private static int CauntExpressionWithTwoNumbers(int a, int b, string sign)
        {
            try
            {
                switch (sign)
                {
                    case "*":
                        return a * b;
                    case "/":
                        return a / b;
                    case "+":
                        return a + b;
                    case "-":
                        return a - b;
                    default:
                        var e = "CauntExpressionWithTwoNumbers failed";
                        LogFile.SaveInFile(e);
                        throw new Exception(e);
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("{0} Exception caught.", e);
                LogFile.SaveInFile(e.ToString());
                throw;
            }
      }        
    }
}
