using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static string expression = "2+3+(3*(2 + 4 * 5 - 8/2))+8";
        static char[] operators = { '+', '-', '*', '/' };

        static void Main(string[] args)
        {
            expression = expression.Replace(" ","");
            // checking validation
            
            NewMethod();

        }

        private static void NewMethod()
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
                inBrakets = inBrakets.Replace("+-", "-");
                inBrakets = inBrakets.Replace("--", "-");
                //what with '*-'
                //what with '/-'

                var withoutBrakets = inBrakets.Trim('(', ')');

                var values = withoutBrakets.Split(operators);
                var valuesAmount = values.Length;

                var multiplicationIndex = withoutBrakets.IndexOf('*');
                var divisionIndex = withoutBrakets.IndexOf('/');
                var additionIndex = withoutBrakets.IndexOf('+');
                var subtractionIndex = withoutBrakets.IndexOf('-');


                var multiPreviousValueIndex = -2;
                var multiPreviousValue = -1;
                var multiSeparator = 1;

                if (multiplicationIndex > -1)
                {

                    while (multiPreviousValueIndex < (multiplicationIndex - 1))
                    {
                        multiPreviousValue++;

                        var number = values[multiPreviousValue].ToString().Length;
                        multiPreviousValueIndex = multiPreviousValueIndex + number + multiSeparator;

                    }
                    int a = int.Parse(values[multiPreviousValue]);
                    int b = int.Parse(values[multiPreviousValue+1]);
                    var multiplication = a*b;

                }

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
                    int b = int.Parse(values[devidePreviousValue+1]);
                    var division = a / b;

                }

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

                }


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

                }



            }
        }
    }
}
