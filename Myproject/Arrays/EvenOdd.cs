using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class EvenOdd
    {
        static void Main(string[] args)
        {
            int[] n = { 1, 2, 3, 4, 5 };
            Console.WriteLine(String.Join(",",n));

            for(int i=0; i<n.Length; i++)
            {
                if(n[i] % 2 ==0)
                {
                    Console.WriteLine("The number is even" +n[i]);
                }
                else
                {
                    Console.WriteLine("The number is odd." +n[i]);
                }
            }

        }
    }
}
