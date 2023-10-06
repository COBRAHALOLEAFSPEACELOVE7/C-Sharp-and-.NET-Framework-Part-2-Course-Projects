using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Employee
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator == (Employee emp1, Employee emp2)
        {
            return emp1.id == emp2.id;
        }
      public static bool operator != (Employee emp1, Employee emp2)
        {
            return emp1.id != emp2.id;
        }
    }
}

