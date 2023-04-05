using System;

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
                
                var student = new Student()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Age = age
                };

                db.Students.Add(student);
                db.SaveChanges();

            }
        }
    }
}
