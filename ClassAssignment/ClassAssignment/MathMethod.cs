using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassAssignment
{
    class MathMethod
    {
        // creates a void method that outputs an integer, divides data passed by 2
        public void MathOperation(int p)
        {
            Console.WriteLine(p / 2);
            Console.ReadLine();
        }

        // creates a method with output parameters
        public void Add50(int p, out int p2, out int p3)
        {
            p2 = 50 + p;
            p3 = 50 + p2;
        }

        // overloading a method
        public void MathOperation(int p, int p2)
        {
            Console.WriteLine(p * p2);
            Console.ReadLine();
        }
    }
}
