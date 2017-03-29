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
            int result = 0;
            foreach (int n in number)
            {
                result = result - n;
            }
            return result;
        }
        public static int multiplicating(params int[] number)
        {
            int result = 0;
            foreach (int n in number)
            {
                result = result * n;
            }
            return result;
        }
        public static int divisioning(params int[] number)
        {
            int result = number[0];
            //number.RemoveAt(0);
            foreach (int n in number)
            {
                result = result / n;
            }
            return result;
        }


    }
}
