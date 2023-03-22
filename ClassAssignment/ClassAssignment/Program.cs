using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates the class
            MathMethod mathMethod = new MathMethod();
            // prompts user to enter a number
            Console.WriteLine("Enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            // calls the method for userNum, displays output
            mathMethod.MathOperation(userNum);
        }
    }
}
