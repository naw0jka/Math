using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public enum Options { A = 0, S = 1, M = 2, D = 3, X = 4 };

    public static class Option
    {
        public static void Select(Options option)
        {
            switch (option)
            {
                case Options.A:

                case Options.S:

                case Options.M:

                case Options.D:

                case Options.X:
                    Sentence.Lunch();
                    break;
                default:
                    Sentence.AlertWrongKey(ConsoleColor.Blue);
                    break;
            }
        }
    }

}
