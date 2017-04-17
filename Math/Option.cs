using System;


namespace Math
{
    public static class Option
    {

        public static void Menu()
        {
            Sentence.Menu();
            RunSelected(Console.ReadKey().Key);
        }
        
        private static void RunSelected(ConsoleKey key)
        {
            string sign = "";


            switch (key)
            {
                case ConsoleKey.A:
                    sign = "+";
                    OneOperatorExpression.resolving(sign);
                    break;
                case ConsoleKey.S:
                    sign = "-";
                    OneOperatorExpression.resolving(sign);
                    break;
                case ConsoleKey.M:
                    sign = "*";
                    OneOperatorExpression.resolving(sign);
                    break;
                case ConsoleKey.D:
                    sign = "/";
                    OneOperatorExpression.resolving(sign);
                    break;
                case ConsoleKey.E:
                    //Calculator.resolving();
                    break;
                case ConsoleKey.X:
                    Sentence.Lunch();
                    break;
                default:
                    Sentence.AlertWrongKey(ConsoleColor.Blue);
                    RunSelected(Console.ReadKey().Key);
                    break;
            }

            



        }
    }
}
