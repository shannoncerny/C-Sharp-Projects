using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Shannon";
            //string quote = "The man said \"Hello.\" \n Hello on a new line \t Hello on a tab.";
            //string fileName = @"C:\Users\Shannon";

            //bool trueOrFalse = name.Contains("s");
            //trueOrFalse = name.EndsWith("s");

            //int length = name.Length;

            //name = name.ToUpper();

            //Console.WriteLine(trueOrFalse);
            //Console.ReadLine();

            //string name = "Shannon";
            //name = "Aaron"; // prints aaron on console

            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jesse");


            Console.WriteLine(sb);
            Console.ReadLine();
        }
    }
}
