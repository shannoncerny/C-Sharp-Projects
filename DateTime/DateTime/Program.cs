using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        // prints cuurrent date & time to console
        Console.WriteLine("Current date: " + DateTime.Now);

        // prompts user to enter number
        Console.WriteLine("Enter a number:");
        string userNum = Console.ReadLine();
        double userNumDouble = Convert.ToDouble(userNum);
        
        // prints exact time it will be in x hours, x = user input
        DateTime newTime = DateTime.Now.AddHours(userNumDouble);
        Console.WriteLine("In {0} hours, it will be {1}.", userNum, newTime);
        Console.ReadLine();
    }
}

