using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // creates a list of integers
        List<int> numList = new List<int>();
        numList.Add(10);
        numList.Add(12);
        numList.Add(14);
        numList.Add(16);
        numList.Add(18);
        numList.Add(20);
        
        // try catch block to catch exceptions and display error messages
        try
        {
            // prompts user to enter a number
            Console.WriteLine("Enter a number:");
            int userNum = Convert.ToInt32(Console.ReadLine());
            // creates a loop that divides each int in list by the user number
            foreach (int number in numList)
            {
                Console.WriteLine(number + " divided by " + userNum + " equals " + number / userNum);
            }
        }
        // displays error message if user enters 0
        catch (DivideByZeroException ex)
        {
            Console.WriteLine("You cannot divide by 0.");
        }
        // displays error message if user enters a string
        catch (FormatException ex)
        {
            Console.WriteLine("Please enter a whole number.");
        }
        // displays error message for any other error
        catch (Exception ex)
        {
            Console.WriteLine(ex);
        }

        Console.WriteLine("The program has emerged from the try/catch block and continued with execution.");
        Console.ReadLine();

    }
}

