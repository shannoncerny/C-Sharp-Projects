using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodClass
{
    class MathMethod
    {
        // creates void method that takes two integers as parameters
        public void MathOperation(int p, int p2)
        {
            // performs math opreation on first int, displays second int 
            int sum = p + 50;
            Console.WriteLine(sum);
            Console.WriteLine(p2);
            Console.ReadLine();
        }
    }
}
