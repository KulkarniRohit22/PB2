using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class NegativeSquareElement
    {
        static void Main(string[] args)
        {
            int[] p = { 12, -13, -15, 11, -7 };
            int square = 1;

            Console.WriteLine(String.Join(",",p));

            for(int i=0; i<p.Length; i++)
            {
                if(p[i] < 0)
                {
                    p[i] = p[i] * p[i];
                }
            }
            Console.WriteLine("////////////////////////////////////");
            for(int i=0; i<p.Length; i++)
            {
                Console.WriteLine(p[i] + " ");
            }
        }
    }
}
