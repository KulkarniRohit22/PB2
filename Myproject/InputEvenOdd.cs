﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class InputEvenOdd
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());

            if(num % 2 == 0 )
            {
                Console.WriteLine("The number is even number!!!");
            }
            else
            {
                Console.WriteLine("The number is odd number!!");
            }
        }

    }
}
