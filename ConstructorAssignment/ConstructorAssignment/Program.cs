using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates a const variable
            const string name = "Shannon";
            Console.WriteLine("Hello, {0}!", name);

            // creates variable using "var"
            var x = 47;
            Console.WriteLine("The variable is {0}", x);

            var person1 = new Person("Cerny", "Shannon");
            var person2 = new Person("Cerny", "Shannon", "Nicole");

            Console.ReadLine();
        }
    }
}
