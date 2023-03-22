using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            // creates object of type IQuittable, calls Quit method
            IQuittable employee = new Employee();
            employee.Quit();
        }
    }
}
