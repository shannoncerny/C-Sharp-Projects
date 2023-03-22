using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates the class
            MathMethod mathMethod = new MathMethod();
            //prompts user to input two integers, one of them optional
            Console.WriteLine("Enter a number:");
            string userNum = Console.ReadLine();
            Console.WriteLine("Enter a second number (optional):");
            string userNum2 = Console.ReadLine();

            // calls the class method and passes in the user input
            if (userNum2 != "")
            {
                int mathOperation = mathMethod.MathOperation(Convert.ToInt32(userNum), Convert.ToInt32(userNum2));
                Console.WriteLine(userNum + " * " + userNum2 + " = " + mathOperation);
            }
            else
            {
                int mathOperation = mathMethod.MathOperation(Convert.ToInt32(userNum));
                Console.WriteLine(userNum + " * 2 = " + mathOperation);
            }
            Console.ReadLine();
        }
    }
}
