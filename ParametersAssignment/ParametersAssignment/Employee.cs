using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametersAssignment
{
    // creates class with generic type parameter
    public class Employee<T>
    {
        // adds a property with a generic list data type
        public List<T> Things { get; set; }
    }
}
