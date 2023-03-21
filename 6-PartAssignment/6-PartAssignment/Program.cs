using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        // ASSIGNMENT PART ONE

        // creates a string array pets and prompts user to enter name
        string[] pets = { "Goose loves ", "Pigeon loves ", "Flint loves ", "Alfredo loves ", "Murphy loves " };
        Console.WriteLine("What is your name?");
        string userName = Console.ReadLine();

        // iterates through array, appends user input to end of each string
        for (int p = 0; p < pets.Length; p++)
        {
            pets[p] = pets[p] + userName;
        }

        // iterates through array, displays each string
        for (int p = 0; p < pets.Length; p++)
        {
            Console.WriteLine(pets[p]);
        }

        // ASSIGNMENT PART TWO

        // creates an infinite loop
        while (true)
        {
            Console.WriteLine("This is a loop.");
            // breaks out of the infinite loop
            break;
        }

        // ASSINGMENT PART THREE

        // creates a loop using a < operator to determine whether to continue iteration or not
        int[] numArray = { 11, 23, 47, 95, 191, 383 };
        for (int i = 0; i < numArray.Length; i++)
        {
            Console.WriteLine(numArray[i]);
        }

        // creates a loop using a <= operator to determine whether to continue iteration or not
        int[] numArray2 = { 2, 4, 5, 7, 6, 3, 9 };
        for (int i = 0; i <= 6; i++)
        {
            Console.WriteLine(numArray2[i]);
        }

        // ASSIGNMENT PART FOUR

        // creates a list of strings
        List<string> seasonsList = new List<string>();
        seasonsList.Add("Fall");
        seasonsList.Add("Winter");
        seasonsList.Add("Spring");
        seasonsList.Add("Summer");
        // prompts user to input text to search for season in list
        Console.WriteLine("Enter a season to select:");
        string userSeason = Console.ReadLine();
        // creates a loop that iterates through list and displays index of list item that contains matching text
        bool found = false;
        for (int s = 0; s < seasonsList.Count; s++)
        {
            if (userSeason == seasonsList[s])
            {
                Console.WriteLine("The season you selected is at index: " + s);
                found = true;
                // breaks the loop after match is found
                break;
            }
        }
        // checks if user input does not exist in list and if so displays error message
        if (!found)
        {
            Console.WriteLine("Your input does not exist in the list.");
        }

        // ASSIGMENT PART FIVE

        // creates a string list with two identical strings
        List<string> nameList = new List<string>();
        nameList.Add("Shannon");
        nameList.Add("Aaron");
        nameList.Add("Spencer");
        nameList.Add("Kimberli");
        nameList.Add("Aaron");
        nameList.Add("Mark");
        // prompts user to select name to search for in list
        Console.WriteLine("Enter a name to search for:");
        string nameInput = Console.ReadLine();

        // creates loop that iterates through list and displays index of item(s) matching the user input
        bool found1 = false;
        for (int n = 0; n < nameList.Count; n++)
        {
            if (nameInput == nameList[n])
            {
                Console.WriteLine("The name you chose is at index: " + n);
                found1 = true;
            }
        }

        if (!found1)
        {
            Console.WriteLine("Your input does not exist in the list.");
            Console.ReadLine();
        }

        // ASSIGNMENT PART SIX

        // creates a string list of letters
        List<string> letterList = new List<string>();
        letterList.Add("L");
        letterList.Add("M");
        letterList.Add("N");
        letterList.Add("O");
        letterList.Add("P");
        

        // creates a second list to keep track of duplicates
        List<string> duplicates = new List<string>();
        duplicates.Add("L");

        // creates a for each loop that evaluates each item and determines whether it appears more than once in list
        foreach (string letter in letterList)
        {
            int counter = 0;
            foreach (string letter2 in letterList)
            {
                if (letter2 == letter)
                {
                    counter++;
                }
            }
            if (counter == 1)
            {
                Console.WriteLine(letter + "- This item is unique.");
            }
            else
            {
                Console.WriteLine(letter + "- This item is a duplicate.");
            }
            

            // checks to see if the items in list appear in the duplicate list
            if (duplicates.Contains(letter))
            {
                Console.WriteLine(letter + "- This item is a duplicate.");
            }
            
        }
        Console.ReadLine();
    }
}

