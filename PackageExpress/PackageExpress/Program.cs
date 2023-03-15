using System;

namespace PackageExpress
{
    class Program
    {
        static void Main()
        {
            // takes user input and converts to integer
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.\n" +
                "Enter package weight:");
            int pkgWeight = Convert.ToInt32(Console.ReadLine());

            // displays error message if weight is greater than 50, otherwise it prompts user for package width
            // converts user input to integer
            if (pkgWeight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            }
            else
            {
                Console.WriteLine("Enter package width:");
            }
            int pkgWidth = Convert.ToInt32(Console.ReadLine());

            // prompts user for package height and converts to integer
            Console.WriteLine("Enter package height:");
            int pkgHeight = Convert.ToInt32(Console.ReadLine());

            // prompts user for package length and converts to integer
            Console.WriteLine("Enter package length:");
            int pkgLength = Convert.ToInt32(Console.ReadLine());

            // displays an error message if the total dimensions are greater than 50,
            // otherwise it multiplies the dimensions and divides by 100 to get shipping quote
            if (pkgWidth + pkgHeight + pkgLength == 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
            }
            else
            {
                int result = ((pkgWidth * pkgLength * pkgHeight) * pkgWeight) / 100;
                Console.WriteLine("Your estimated total for shipping this package is: $" + result +".00\nThank you!");
            }
            Console.ReadLine();
        }
    }
}
