using System;

namespace Math
{
    public static class Sentence
    {
        private static string newLine = "\r\n";

        public static string Start()
        {
            Console.WriteLine(Library.greetings + newLine + Library.name + newLine);
            return Console.ReadLine();
        }
        public static void Menu()
        {
            string[] questions= {
                Library.optionAdding,
                Library.optionSubstraction,
                Library.optionMultiplication,
                Library.optionDividing,
                Library.optionLunch,
                Library.exit, ""};
            foreach (string i in questions)
            {
                Console.WriteLine(i);
            }
        }

        public static void AlertWrongKey(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine(Library.wrongKey1);
            Console.ResetColor();
        }

        public static void End()
        {
            Console.WriteLine(Library.exit);
        }
        public static void Lunch()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(newLine + newLine + Library.lunch + newLine);
            Console.ResetColor();
        }
    }
}
