using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Topic2Assignment
{
    class Assignment1
    {
        //Write a programme to find whether a year is a leap year or not
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a year!!");
            int year = Convert.ToInt32(Console.ReadLine());

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
            {
                Console.WriteLine("A year is a leap year:" + year);
            }
            else
            {
                Console.WriteLine("A year is not leap year:");
            }

        }
     
    }
}
