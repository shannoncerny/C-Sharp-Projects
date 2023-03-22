using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    // creates class that inherits interface
    public class Employee : IQuittable
    {
        public int Id { get; set; }

        public void Quit()
        {
            Console.WriteLine("Quitting program...");
            Console.ReadLine();
        }
    }
}
