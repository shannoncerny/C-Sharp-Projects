using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            // instantiates the class and calls the method, passing in an integer
            MathMethod mathMethod = new MathMethod();
            int mathOperation = mathMethod.MathOperation(22);
            Console.WriteLine("22 plus 50 equals " + mathOperation);

            // instantiates the class and calls the second method, passing in a decimal
            MathMethod mathMethod2 = new MathMethod();
            int mathOperation2 = mathMethod2.MathOperation(22.5M);
            Console.WriteLine("22.5 divided by 3 equals " + mathOperation2);

            // instantiates the class and calls the third method, passing in a string
            MathMethod mathMethod3 = new MathMethod();
            int mathOperation3 = mathMethod3.MathOperation("11");
            Console.WriteLine("11 multiplied by 5 equals " + mathOperation3);

            Console.ReadLine();
        }
    }
}
