using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class HwReplacingNegativeValues
    {
        static void Main(string[] args)
        {
            int[] p = { 12, 3, -19, 29, 5, -61, 44, 7, -9 };

            Console.WriteLine(String.Join(",",p));
          

            for(int i =0; i<p.Length; i++)
            {
                if(p[i] < 0)
                {
                    p[i] = p[i-1] * p[i-1];
                }
            }
            Console.WriteLine("///////////////////////////////////////");
            Console.WriteLine(String.Join(",",p));
        }
    }
}
