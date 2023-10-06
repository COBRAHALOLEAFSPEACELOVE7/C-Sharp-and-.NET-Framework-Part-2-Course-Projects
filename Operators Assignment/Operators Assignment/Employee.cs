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

        // Overloaded == and returned true if emp1's id is equal to emp2's id
        public static bool operator == (Employee emp1, Employee emp2)
        {
            return emp1.id == emp2.id;
        }
        // Overloaded == and returned false if emp1's id is not equal to emp2's id
        public static bool operator != (Employee emp1, Employee emp2)
        {
            return emp1.id != emp2.id;
        }
    }
}

