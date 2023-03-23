﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaAssignment
{
    class Employee
    {
        // class properties
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Employee(int id, string firstName, string lastName)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
