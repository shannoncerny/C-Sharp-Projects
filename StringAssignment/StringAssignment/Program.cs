using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // defines strings
            string sentence1 = "Goose and ";
            string sentence2 = "Pigeon and ";
            string sentence3 = "Mirabelle are cats!";

            // concatenates strings
            string concat = sentence1 + sentence2 + sentence3;
            // converts string to uppercase
            concat = concat.ToUpper();

            Console.WriteLine(concat);

            // creates a StringBuilder and initializes with first sentence
            StringBuilder sb = new StringBuilder("Hello, my name is Shannon. ");

            // adds to end of StringBuilder
            sb.Append("Today it is 11 degrees and sunny ");
            sb.Append("in rural Wisconsin. ");
            sb.Append("Hopefully tomorrow will be warmer.");

            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
