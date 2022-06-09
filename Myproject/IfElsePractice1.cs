using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class IfElsePractice1
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter the number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if (num < 3)
            {
                Console.WriteLine("hi!!");

            }
            else if (num > 3 && num < 10)
            {
                Console.WriteLine("Hello!!");
            }
            else if (num > 10)
            {
                Console.WriteLine("hi hello!!");
            }
            else
            {
                Console.WriteLine("Done");
            }

        }
    }
}
