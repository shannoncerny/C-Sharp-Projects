using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsAndObjects
{
    class Person
    {
       // creates class properties with string data type
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // creates a void method with no parameters, displays full name to console
        public void SayName()
        {
            string fullName = FirstName + " " + LastName;
            Console.WriteLine("Name: " + fullName);
            Console.ReadLine();
        }
    }
}
