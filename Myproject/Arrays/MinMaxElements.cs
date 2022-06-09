using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class MinMaxElements
    {
        static void Main(string[] args)
        {
            int[] z = { 2, 3, 4, 5 };
            int max = z[0];

            for(int i=0; i<z.Length; i++)
            {
                if(max < z[i])
                {
                    max = z[i];
                }
            }
            Console.WriteLine("The max element is: " + max);
            Console.WriteLine("/////////////////////////////////////////////////");

            Console.WriteLine(String.Join(",",z));
            int min = z[0];
            for(int i=0; i<z.Length; i++)
            {
                if(min>z[i])
                {
                    min = z[i];
                }
            }
            Console.WriteLine("The min element is: " + min);
        }
    }
}
