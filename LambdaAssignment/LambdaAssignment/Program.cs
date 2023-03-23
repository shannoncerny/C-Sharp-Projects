using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a list with data type Employee, adds 10 new employees to list
            List<Employee> employees = new List<Employee>();
            employees.Add(new Employee(1, "Shannon", "Cerny"));
            employees.Add(new Employee(2, "Aaron", "Cerny"));
            employees.Add(new Employee(3, "Joe", "Smith"));
            employees.Add(new Employee(4, "Spencer", "Davis"));
            employees.Add(new Employee(5, "Joe", "Keary"));
            employees.Add(new Employee(6, "Erin", "McMichael"));
            employees.Add(new Employee(7, "Kimberli", "Wood"));
            employees.Add(new Employee(8, "Mark", "McMichael"));
            employees.Add(new Employee(9, "Judy", "Tobin"));
            employees.Add(new Employee(10, "Bob", "Cerny"));

            // creates a new list of all employees with first name "Joe"
            Console.WriteLine("Displaying all employees with name \"Joe\":");
            foreach (Employee employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    List<Employee> joeList = new List<Employee>();
                    joeList.Add(employee);
                    Console.WriteLine(employee.FirstName);
                    Console.ReadLine();
                }
            }

            // creates a new list of all employees with first name "Joe" with lambda expression
            Console.WriteLine("Displaying all employees with name \"Joe\":");
            List<Employee> joeList2 = employees.FindAll(x => x.FirstName == "Joe");
            foreach (Employee employee in joeList2)
            {
                Console.WriteLine(employee.FirstName);
                Console.ReadLine();
            }

            // creates list of all employees with Id number > 5 with lambda expression
            Console.WriteLine("Displaying employees with ID > 5:");
            List<Employee> employeeID = employees.FindAll(x => x.Id > 5);
            foreach (Employee employee in employeeID)
            {
                Console.WriteLine(employee.FirstName + ", " + employee.Id);
                Console.ReadLine();
            }
        }
    }
}
