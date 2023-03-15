using System;

namespace AnonymousIncomeComparison
{
    class Program
    {
        static void Main()
        {
            // prompts person 1 to enter hourly rate and hours worked per week, multiplies by 52 to find annual salary
            // displays person 1 annual salary
            Console.WriteLine("Anonymous Income Comparison Program\n" +
                "Person 1\n" +
                "Please enter your hourly rate: ");
            string hourlyRate1 = Console.ReadLine();
            int rate1 = Convert.ToInt32(hourlyRate1);
            Console.WriteLine("Please enter your hours worked per week: ");
            string hoursWorked = Console.ReadLine();
            int hours1 = Convert.ToInt32(hoursWorked);
            Console.WriteLine("Annual salary of Person 1: $" + (rate1 * hours1) * 52); // 52 weeks in a year

            // prompts person 2 to enter hourly rate and hours worked per week, multiplies by 52 to find annual salary
            // displays person 2 annual salary
            Console.WriteLine("Person 2\n" +
                "Please enter your hourly rate: ");
            string hourlyRate2 = Console.ReadLine();
            int rate2 = Convert.ToInt32(hourlyRate2);
            Console.WriteLine("Please enter your hours worked per week: ");
            string hoursWorked2 = Console.ReadLine();
            int hours2 = Convert.ToInt32(hoursWorked2);
            Console.WriteLine("Annual salary of Person 2: $" + (rate2 * hours2) * 52);

            // prompts user to answer question displays true or false accordingly
            Console.WriteLine("Does Person 1 make more money than Person 2?");
            int income1 = (rate1 * hours1) * 52;
            int income2 = (rate2 * hours2) * 52;
            Console.WriteLine(income1 > income2);

            Console.ReadLine();

        }
    }
}
