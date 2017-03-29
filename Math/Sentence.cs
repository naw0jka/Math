using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public static class Sentence
    {
        

        public static void Start()
            {
                Console.WriteLine(Library.greetings);
                Console.WriteLine(Library.question);
                Console.WriteLine(Library.optionAdding);
                Console.WriteLine(Library.optionSubstraction);
                Console.WriteLine(Library.optionMultiplication);
                Console.WriteLine(Library.optionDividing);
                Console.WriteLine(Library.optionLunch);
                Console.WriteLine(Library.exit);

            }

        public static void AlertWrongKey(ConsoleColor color = ConsoleColor.White)
        {
            Console.ForegroundColor = color;
            Console.WriteLine("You miss the key. Try one more time");
            Console.ResetColor();
        } 
           
        public static void End()
            {
                Console.WriteLine(Library.exit);
            }
        
    }
}
