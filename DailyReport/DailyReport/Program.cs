using System;


class Program
{
    static void Main()
    {
        // displays title of program
        Console.WriteLine("The Tech Academy\n" +
            "Student Daily Report");
        
        // asks for name and allows user input as string data type
        Console.WriteLine("What is your name?");
        string yourName = Console.ReadLine();

        // asks for current course and allows user input as string data type
        Console.WriteLine("What course are you on?");
        string courseName = Console.ReadLine();
        
        // asks for page number and allows user input as string data type and converts to int
        Console.WriteLine("What page number?");
        string pageNumber = Console.ReadLine();
        int pageNum = Convert.ToInt32(pageNumber);

        // asks if help is needed and allows user input as string data type and converts to boolean data type
        Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false.\"");
        string help = Console.ReadLine();
        bool helpAnswer = Convert.ToBoolean(help);

        // asks for positive experiences and allows user input as string data type
        Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
        string posExperience = Console.ReadLine();

        // asks for other feedback and allows user input as string data type
        Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
        string feedback = Console.ReadLine();

        // asks how many hours were studied and allows user input as string data type and converted to int data type
        Console.WriteLine("How many hours did you study today?");
        string hoursStudied = Console.ReadLine();
        int hours = Convert.ToInt32(hoursStudied);

        // displays message implying this is the end of the program
        Console.WriteLine("Thank you for your answers. An instructor will respond to this shortly. Have a great day!");

        Console.ReadLine();

    }
}

