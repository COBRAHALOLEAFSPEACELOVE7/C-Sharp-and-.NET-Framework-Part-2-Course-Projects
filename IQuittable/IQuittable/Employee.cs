using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    // Had the Employee Class inherit from the IQuittable Interface
    public class Employee : IQuittable
    { 
        // Used the Quit method
        public void Quit(string name)
        {
            // Wrote concatenated strings and void method string name to the console
            Console.WriteLine("I," + name + ",Quit!");
        }
    }
}
