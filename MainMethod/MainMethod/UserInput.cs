using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainMethod
{
    class MathMethod
    {
        // creates method that takes in an integer and adds 50
        public int MathOperation(int p)
        {
            return (p + 50);
        }

        // creates method that takes in a decimal and divides by 3
        public int MathOperation(decimal p)
        {
            return (int)(p / 3M);
        }

        // creates method that takes in a string, converts to int, multiplies by 5
        public int MathOperation(string p)
        {
            if (int.TryParse(p, out int value))
            {
                return value * 5;
            }
            else
            {
                throw new InvalidOperationException("Invalid input.");
            }
        }
    }
}
