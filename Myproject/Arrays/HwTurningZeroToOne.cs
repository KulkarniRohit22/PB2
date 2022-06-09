using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class HwTurningZeroToOne
    {
        static void Main(string[] args)
        {
            int[] a = { 26, 0, 67, 45, 0, 78, 54, 34, 10, 0, 34 };

            Console.WriteLine(String.Join(",",a));

            for (int i = 0; i < a.Length; i++)
            {
                if(a[i] == 0)
                {
                    a[i] = 1;
                }
            }
           
            Console.WriteLine(String.Join(",",a));
        }
        
    }
}
