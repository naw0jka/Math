using System;

namespace Math
{
    public class Program
    {
        static string Name;

        static void Main()
        {
            Name = Sentence.Start();
            Sentence.Hi(Name);
            Option.Menu();         
        }
    }
}