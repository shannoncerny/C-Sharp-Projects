using System;

namespace LoopAssignment
{
    class Program
    {
        static void Main()
        {
            // creates while loop
            int i = 0; // sets 0 as integer
            while (i <= 5)
            {
                Console.WriteLine(i);
                i++; // increments by 1
            }

            // prompts user to enter a letter
            Console.WriteLine("Guess a letter:");
            string letter = Console.ReadLine();
            bool isGuessed = letter == "s";

            // creates a do while loop
            do
            {
                // switch statments
                switch (letter)
                {
                    case "a":
                        Console.WriteLine("You guessed \"a\". Try again!");
                        Console.WriteLine("Guess a letter:");
                        letter = Console.ReadLine();
                        break;
                    case "t":
                        Console.WriteLine("You guessed \"t\". Try again!");
                        Console.WriteLine("Guess a letter:");
                        letter = Console.ReadLine();
                        break;
                    case "d":
                        Console.WriteLine("You guessed \"d\". Try again!");
                        Console.WriteLine("Guess a letter:");
                        letter = Console.ReadLine();
                        break;
                    case "s":
                        Console.WriteLine("You guessed \"s\". You are correct!");
                        isGuessed = true;
                        break;
                    default:
                        Console.WriteLine("You are wrong. Try again!");
                        Console.WriteLine("Guess a letter:");
                        letter = Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);

            Console.ReadLine();
        }
    }
}
