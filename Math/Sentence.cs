using System;

namespace Math
{
    public static class Sentence
    {
        private static string newLine = "\r\n";
        private static string newParagraph = newLine + newLine;

        public static string Start()
        {
            Console.WriteLine(Library.greetings + newLine + Library.name + newLine);
            return Console.ReadLine();
        }

        public static void Hi(string name)
        {
            Console.WriteLine(newLine + "Hi " + name +"!");
        }

        public static void Menu()
        {
            string[] questions= {
                newLine,
                Library.startQuestion,
                Library.optionAdding,
                Library.optionSubstraction,
                Library.optionMultiplication,
                Library.optionDividing,
                Library.arithmeticExpression,
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
            Console.WriteLine(newParagraph + Library.wrongKey1);
            Console.ResetColor();
        }

        public static void OneOperatorInstruction()
        {
            Console.WriteLine(newParagraph+Library.oneOperatorInstruction+newLine);
        }

        public static void Outcome(int result)
        {
            Console.WriteLine(newLine + "The result is: " + result.ToString()+".");
        }

        public static void End()
        {
            Console.WriteLine(Library.exit);
        }
        public static void Lunch()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(newParagraph + Library.lunch + newLine);
            Console.ResetColor();
        }
    }
}
