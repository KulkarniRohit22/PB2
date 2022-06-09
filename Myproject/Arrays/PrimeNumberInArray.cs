using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class PrimeNumberInArray
    {
        //take a input of 5 digits and perform sum of the prime numbers in an array.
        static void Main(string[] args)
        {
            int[] p = {3, 3, 5, 7, 20, 7 , 3, 7};
            int count = 0;
            int sum = 0;

            for (int i = 0; i < p.Length; i++)  //main for loop.
            {
                for (int j = 2; j <= p[i] / 2; j++)
                {
                     if (p[i] % j == 0)
                     {
                            count++;
                            break;
                     }
                }
                
                if (count == 0)
                {
                    Console.WriteLine(p[i]);
                    sum = sum + p[i];
                }
                count = 0;
            }
            Console.WriteLine("The addition of prime number is : " + sum);



            /* int[] a = new int[] { 2, 3, 5, 7, 9,11,13,15 };
             int count = 0;
             for (int i = 0; i < a.Length; i++)
             {
                 for (int j = 2; j <= a[i] / 2; j++)
                 {
                     if (a[i] % j == 0)
                     {
                         count = 1;
                         break;
                     }
                 }
                 if (count == 0)
                 {
                     Console.WriteLine(a[i]);
                 }



             }*/

        }

    }
    
}
