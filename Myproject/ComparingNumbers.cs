using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class ComparingNumbers
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("num1 is greater than num2");
            }
            else if (num1 < num2)
            {
                Console.WriteLine("num2 is greater than num1");
            }
            else if(num1 == num2 )
            {
                Console.WriteLine("Both numbers are equal.");
            }
            else
            {
                Console.WriteLine("Done!!");
            }

        }
    }
}
