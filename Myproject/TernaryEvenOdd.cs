using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class TernaryEvenOdd
    { 
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            string result = num % 2 == 0 ? "even" : "odd";
            Console.WriteLine("Result = " + result);
        }
    }
}
