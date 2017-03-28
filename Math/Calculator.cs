using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Calculator
    {
        public static void CalculatorInBrackets(string expression, char[] operators)
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

                CalculateExpressionInBrackets(withoutBrakets, values, valuesAmount, operators, "*");
            }
        }



        private static void CalculateExpressionInBrackets(string withoutBrakets, string[] values, int valuesAmount, char[] operators, string sign)
        {
            var index = withoutBrakets.IndexOf(sign);
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
                var result = a * b;

                withoutBrakets = withoutBrakets.Replace(a.ToString() + '*' + b.ToString(), result.ToString());
                values = withoutBrakets.Split(operators);
            }

            var divisionIndex = withoutBrakets.IndexOf('/');
            var devidePreviousValueIndex = -2;
            var devidePreviousValue = -1;
            var devideSeparator = 1;

            if (divisionIndex > -1)
            {

                while (devidePreviousValueIndex < (divisionIndex - 1))
                {
                    devidePreviousValue++;

                    var number = values[devidePreviousValue].ToString().Length;
                    devidePreviousValueIndex = devidePreviousValueIndex + number + devideSeparator;

                }
                int a = int.Parse(values[devidePreviousValue]);
                int b = int.Parse(values[devidePreviousValue + 1]);
                var division = a / b;

                withoutBrakets = withoutBrakets.Replace(a.ToString() + '/' + b.ToString(), division.ToString());
                values = withoutBrakets.Split(operators);
            }

            var additionIndex = withoutBrakets.IndexOf('+');
            var additionPreviousValueIndex = -2;
            var additionPreviousValue = -1;
            var additionSeparator = 1;

            if (additionIndex > -1)
            {

                while (additionPreviousValueIndex < (additionIndex - 1))
                {
                    additionPreviousValue++;

                    var number = values[additionPreviousValue].ToString().Length;
                    additionPreviousValueIndex = additionPreviousValueIndex + number + additionSeparator;

                }
                int a = int.Parse(values[additionPreviousValue]);
                int b = int.Parse(values[additionPreviousValue + 1]);
                var addition = a + b;

                withoutBrakets = withoutBrakets.Replace(a.ToString() + '+' + b.ToString(), addition.ToString());
                values = withoutBrakets.Split(operators);
            }

            var subtractionIndex = withoutBrakets.IndexOf('-');
            var subtractionPreviousValueIndex = -2;
            var subtractionPreviousValue = -1;
            var subtractionSeparator = 1;

            if (subtractionIndex > -1)
            {

                while (subtractionPreviousValueIndex < (subtractionIndex - 1))
                {
                    subtractionPreviousValue++;

                    var number = values[subtractionPreviousValue].ToString().Length;
                    subtractionPreviousValueIndex = subtractionPreviousValueIndex + number + subtractionSeparator;

                }
                int a = int.Parse(values[subtractionPreviousValue]);
                int b = int.Parse(values[subtractionPreviousValue + 1]);
                var substraction = a - b;

                withoutBrakets = withoutBrakets.Replace(a.ToString() + '-' + b.ToString(), substraction.ToString());
                values = withoutBrakets.Split(operators);
            }
        }
    }
}
