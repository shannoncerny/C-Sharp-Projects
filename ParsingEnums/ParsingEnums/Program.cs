using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParsingEnums
{
    class Program
    {
        static void Main(string[] args)
        {
            // prompts user to enter current day of week
            Console.WriteLine("Please enter the day of the week:");
            string userInput = Console.ReadLine();

            // try and catch block to display error message if error occurs
            try
            {
                // assigns value to a variable of enum data type
                DaysOfTheWeek daysOfTheWeek = (DaysOfTheWeek)Enum.Parse(typeof(DaysOfTheWeek), userInput);
                Console.WriteLine("You entered: " + daysOfTheWeek.ToString());
                Console.ReadLine();
            }
            catch
            {
                Console.WriteLine("Please enter an actual day of the week.");
                Console.ReadLine();
            }
        }
    }
}
