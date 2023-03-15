using System;

namespace MathApp
{
    class Program
    {
        static void Main()
        {
            // prompts user to enter a number, then multiples user input by 50
            Console.WriteLine("Please enter a number: ");
            string userNumber = Console.ReadLine();
            int userNum = Convert.ToInt32(userNumber);
            Console.WriteLine("Your number multiplied by 50 is: " + userNum * 50);

            // prompts user to enter a number, then adds 25 to user input
            Console.WriteLine("Please enter another number: ");
            string secondNumber = Console.ReadLine();
            int userNum2 = Convert.ToInt32(secondNumber);
            Console.WriteLine("Your number plus 25 is: " + (userNum2 + 25));

            // prompts user to enter a number, then divides user input by 12.5
            Console.WriteLine("Please enter another number: ");
            string thirdNumber = Console.ReadLine();
            int userNum3 = Convert.ToInt32(thirdNumber);
            Console.WriteLine("Your number divided by 12.5 is: " + userNum3/12.5);

            // prompts user to enter a number, then checks if user input is greater than 50
            Console.WriteLine("Please enter another number: ");
            string fourthNumber = Console.ReadLine();
            int num4 = Convert.ToInt32(fourthNumber);
            if (50 > num4)
            {
                Console.WriteLine(false);
            }
            else
            {
                Console.WriteLine(true);
            }

            // prompts user to enter a number, then divides user input by 7 and prints remainder
            Console.WriteLine("Please enter another number: ");
            string fifthNumber = Console.ReadLine();
            int num5 = Convert.ToInt32(fifthNumber);
            Console.WriteLine("The remainder of your number divided by 7 is: " + num5 % 7);

            Console.ReadLine();
        }
    }
}
