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
            // Created two employee objects
            Employee emp1 = new Employee();
            emp1.id = 1;

            Employee emp2 = new Employee();
            emp2.id = 1;

            // Created an if statement that will write Equal :) if emp1's id is equal to emp's2 id
            if (emp1 == emp2)
            {
                Console.WriteLine("Equal :)");
            }
            Console.ReadLine();
        }
    }
}
