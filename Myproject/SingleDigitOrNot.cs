using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SingleDigitOrNot
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num <= 9)
            {
                Console.WriteLine("The number is single digit.");
            }
            else
            {
                Console.WriteLine("The number is double digit.");
            }
        }
    }
}
