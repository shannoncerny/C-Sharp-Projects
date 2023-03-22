using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee
    {
        // creates properties with int data type and string data types
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // overload "==" operator, checks if 2 employee objects are equal by checking Id
        public override bool Equals(object obj)
        {
            Employee employee = (Employee)obj;
            if (Id == employee.Id)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool operator ==(Employee employee, Employee employee2)
        {
            return employee.Equals(employee2);
        }
        public static bool operator !=(Employee employee, Employee employee2)
        {
            return !employee.Equals(employee2);
        }

    }
}
