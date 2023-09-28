using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiates Hockey777 class
            Hockey777 hock = new Hockey777();
            // Asks the user to provide a number or parameter 
            Console.WriteLine("Hi please enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you");
            // Asks the user to provide a second number or parameter
            Console.WriteLine("Please enter a second number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Thank you");
            // Calls the method
            int result = hock.Hockey(num1, num2);
            Console.WriteLine(num1 + " + " + num2 + " = " + result);
            Console.WriteLine("Thank you :) please press Enter to close this");
            Console.ReadLine();
        }
    }
}
