using FinalChallengeAssignment;
using System;
using System.Linq;

namespace FinalChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (var db = new StudentContext())
            {
                Console.WriteLine("Enter your first name:");
                string firstName = Console.ReadLine();
                Console.WriteLine("Enter your last name:");
                string lastName = Console.ReadLine();
                Console.WriteLine("Enter your age:");
                int age = Convert.ToInt32(Console.ReadLine());

                Student student = new Student
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };

                db.Students.Add(student);
                db.SaveChanges();

                var query = from b in db.Students
                            orderby b.LastName
                            select b;
                Console.WriteLine("All students in the database: \n");
                foreach (var item in query)
                {
                    Console.WriteLine(item.Id + ": " + item.LastName + ", " + item.FirstName);
                }
                Console.WriteLine("Press any key to exit...");
                Console.ReadKey();
            }
        }
    }
}
