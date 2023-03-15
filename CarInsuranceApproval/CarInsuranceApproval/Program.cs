using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarInsuranceApproval
{
    class Program
    {
        static void Main()
        {
            // prompts user to enter age, converts string to integer
            Console.WriteLine("What is your age?");
            string userAge = Console.ReadLine();
            int age = Convert.ToInt32(userAge);

            // asks if user has dui, converts string to boolean
            Console.WriteLine("Have you ever had a DUI?");
            string userDUI = Console.ReadLine();
            bool DUI = Convert.ToBoolean(userDUI);

            // prompts user to enter amount of speeding tickets, converts string to integer
            Console.WriteLine("How many speeding tickets do you have?");
            string speedingTickets = Console.ReadLine();
            int tickets = Convert.ToInt32(speedingTickets);

            // determines if user qualifies for car insurance based on user inputs
            bool qualifies = (age >= 15 && DUI == false && tickets < 3);
            Console.WriteLine("Qualifies? " + qualifies);

            Console.ReadLine();
        }
    }
}
