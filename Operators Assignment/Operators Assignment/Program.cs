using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Operators_Assignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.id = 1;

            Employee emp2 = new Employee();
            emp2.id = 1;

            if (emp1 == emp2)
            {
                Console.WriteLine("Equal :)");
            }
            Console.ReadLine();
        }
    }
}
