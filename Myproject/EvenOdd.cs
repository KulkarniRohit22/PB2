using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num % 2 == 0)
            {
                Console.WriteLine("The number is even. ");
            }
            else
            {
                Console.WriteLine("The number is odd.");
            }

        }
    }
}
