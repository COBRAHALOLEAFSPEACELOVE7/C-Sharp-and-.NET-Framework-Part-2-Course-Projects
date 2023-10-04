using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQuittable
{
    class Program
    {
        static void Main(string[] args)
        {
            // Created an object of type IQuittable and called the Quit method on it
            IQuittable quitter = new Employee();
            quitter.Quit("Mark");
        }
    }
}
