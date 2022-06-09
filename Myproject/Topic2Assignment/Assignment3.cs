using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Topic2Assignment
{
    class Assignment3
    {
        //Write a programe to find the maximum number between three numbers.
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number.");
            int num3 = Convert.ToInt32(Console.ReadLine());

            if(num1 > num2)
            {
                if(num1 > num3)
                {
                    Console.WriteLine("Num1 is maximum:" + num1);
                }
                else
                {
                    Console.WriteLine("num3 is maximum: " + num3);
                }
            }
            else if(num2 > num3)
            {
                Console.WriteLine("Num2 is maximum:" + num2);
            }
            else
            {
                Console.WriteLine("THe num3 is maximum:" + num3);
            }
        }
    }
}
