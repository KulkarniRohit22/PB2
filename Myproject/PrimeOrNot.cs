using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class PrimeOrNot
    {
        static void Main(string[] args)
        {
            int count = 0, sum = 0;

            Console.WriteLine("Prime numbers between 1 and 10 are: ");

            for (int i = 1; i < 10; i++)
            {
                count = 0;
                if (i > 0)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }

                    }

                    if (count == 0)
                    {
                        Console.WriteLine(i + "  ");
                        sum = sum + i;
                    }
                }


            }
            Console.WriteLine("The Sum of the prime numbers are: " + sum);


            Console.WriteLine("////////////////////////////////////////////////////////////////////////////////////////////////////////////////////");


          /*  Console.WriteLine("Enter a number.");
            int num = Convert.ToInt32(Console.ReadLine());
            bool IsPrime = true;

            for (int i = 2; i < num ; i++)
            {
                if (num % i == 0)
                {
                    IsPrime = false;
                    break;
                }
            }
            if (IsPrime)
            {
                Console.WriteLine("The number is prime");
            }
            else
            {
                Console.WriteLine("The number is not prime.");
            }*/


        }
    }
}
