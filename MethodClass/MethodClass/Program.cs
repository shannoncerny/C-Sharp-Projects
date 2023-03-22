using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates the class
            MathMethod mathMethod = new MathMethod();
            // calls class method, passes in two numbers
            mathMethod.MathOperation(25, 80);
            // calls class method, specifies numbers by parameter name
            mathMethod.MathOperation(p: 25, p2: 80);
        }
    }
}
