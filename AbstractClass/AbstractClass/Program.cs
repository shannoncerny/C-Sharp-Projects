using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates employee object and passes in values for firstname and lastname
            Employee employee = new Employee() { FirstName = "Sample", LastName = "Student" };
            // calls SayName method on employee object
            employee.SayName();
        }
    }
}
