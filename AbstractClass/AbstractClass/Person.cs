using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClass
{
    // creates abstract class 
    public abstract class Person
    {
        // creates properties with string data types
        public string FirstName { get; set; }
        public string LastName { get; set; }

        // creates abstract method
        public abstract void SayName();
    }
}
