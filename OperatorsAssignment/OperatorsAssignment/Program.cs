using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates class objects, assigns values to the properties
            Employee employee = new Employee() 
            { 
                Id = 1,
                FirstName = "Jane", 
                LastName = "Doe" 
            };
            Employee employee2 = new Employee()
            {
                Id = 2,
                FirstName = "Bob",
                LastName = "Smith"
            };
            // compares the employee objects using overloaded operators, displays results
            if (employee == employee2)
            {
                Console.WriteLine("Employee is equal to Employee2.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Employee is not equal to Employee2.");
                Console.ReadLine();
            }
        }
    }
}
