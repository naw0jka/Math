using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Sentence
    {
        Library L = new Library();

        public void Start()
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
           
        public void end()
            {
                Console.WriteLine(Library.exit);
            }
        
    }
}
