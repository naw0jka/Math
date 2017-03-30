using System;

namespace Math
{
    public static class Option
    {
        public static void Select()
        {
            RunSelected(Console.ReadKey().Key);
        }


        public static void RunSelected(ConsoleKey key)
        {
            switch (key)
            {
                case ConsoleKey.A:
                    break;
                case ConsoleKey.S:
                    break;
                case ConsoleKey.M:
                    break;
                case ConsoleKey.D:
                    break;
                case ConsoleKey.X:
                    Sentence.Lunch();
                    break;
                default:
                    Sentence.AlertWrongKey(ConsoleColor.Blue);
                    break;
            }
        }
    }
}
