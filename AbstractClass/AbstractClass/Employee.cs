using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // creates class that inherits from Person class
    public class Employee : Person
    {
        // implements SayName method
        public override void SayName()
        {
            Console.WriteLine(FirstName + " " + LastName);
            Console.ReadLine();
        }
    }
}
