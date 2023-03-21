using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallingMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompts user to enter a number to perform math operation, converts to int data type
            Console.WriteLine("Enter a number to perform math operations on:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            UserInput userInput = new UserInput();

            // calls each method and passes in user input
            int divideTwo = userInput.DivideTwo(userNum);
            int addFifty = userInput.AddFifty(userNum);
            int multiplyFive = userInput.MultiplyFive(userNum);

            // displays returned integer
            Console.WriteLine(userNum + " divided by 2 equals " + divideTwo);
            Console.WriteLine(userNum + " plus 50 equals " + addFifty);
            Console.WriteLine(userNum + " multiplied by 5 equals " + multiplyFive);

            Console.ReadLine();
        }
    }
}
