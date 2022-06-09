using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class PrimeNumberOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int num = Convert.ToInt32(Console.ReadLine());
            bool IsPrime = true;

            for(int i=2; i < num; i++)
            {
                if(num % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if(IsPrime == true)
            {
                Console.WriteLine("The number is a prime number");
            }
            else
            {
                Console.WriteLine("The number is not a prime number.");
            }

        }

    }
}
