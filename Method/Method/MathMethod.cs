using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class MathMethod
    {
        // creates method tthat takes two integers as parameters, one optional
        // performs math operation and returns int result
        public int MathOperation(int p, int p2 = 2)
        {
            return p * p2;
        }
    }
}
