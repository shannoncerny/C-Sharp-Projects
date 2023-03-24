using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace InputAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompts user to enter a number
            Console.WriteLine("Enter a number:");
            string userNum = Console.ReadLine();
            // logs user input to text file
            using (StreamWriter file = new StreamWriter(@"C:\Users\shann\OneDrive\Documents\GitHub\Tech-Academy-Projects\Basic_C#_Programs\InputAssignment\Logs\log.txt", true))
            {
                file.WriteLine(userNum);
            }
            // prints text back to user
            Console.WriteLine("Your number is {0}", userNum);
            Console.ReadLine();
        }
    }
}
