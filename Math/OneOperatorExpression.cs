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
