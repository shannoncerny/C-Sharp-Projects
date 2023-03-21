using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // creates string array, prompts user to select an index
        string[] stringArray = { "Fall", "Summer", "Winter", "Spring" };
        Console.WriteLine("Select an index to choose a season:");
        int stringIndex = Convert.ToInt32(Console.ReadLine());
        
        // displays the season based on the user's chosen index
        if (stringIndex < 0)
        {
            Console.WriteLine("That index does not exist.");
        }        
        else if (stringIndex < stringArray.Length)
        {
            Console.WriteLine("You chose: " + stringArray[stringIndex]);
        }
        // displays an error message if the index user selected doesn't exist
        else
        {
            Console.WriteLine("That index does not exist.");
        }

        // creates integer array, prompts user to select an index
        int[] intArray = { 4, 5, 6, 7, 8, 9 };
        Console.WriteLine("Select an index to choose a number:");
        int integerIndex = Convert.ToInt32(Console.ReadLine());

        // displays number based on user's selected index

        // displays an error message if the index user selected doesn't exist
        if (integerIndex < 0)
        {
            Console.WriteLine("That index does not exist.");
        }
        else if (integerIndex < intArray.Length)
        {
            Console.WriteLine("You chose: " + intArray[integerIndex]);
        } 
        else
        {
            Console.WriteLine("That index does not exist.");
        }


        // creates a list of strings
        List<string> stringList = new List<string>(7);
        stringList.Add("Shannon");
        stringList.Add("Aaron");
        stringList.Add("Kimberli");
        stringList.Add("Mark");
        stringList.Add("Spencer");
        stringList.Add("Michelle");
        stringList.Add("Chris");

        // prompts user to select an index to choose a name
        Console.WriteLine("Select an index to choose a name:");
        int selectedString = Convert.ToInt32(Console.ReadLine());

        // displays name based on user's selected index
        if (selectedString < 0)
        {
            Console.WriteLine("That index does not exist.");
            Console.ReadLine();
        }
        else if (selectedString < stringList.Count)
        {
            Console.WriteLine("You chose: " + stringList[selectedString]);
            Console.ReadLine();
        }
        else
        {
            Console.WriteLine("That index does not exist.");
        }

    }
}

