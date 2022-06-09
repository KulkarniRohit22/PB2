using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class HwReversingArray
    {
        static void Main(string[] args)
        {
            int[] a = { 3, 90, 45, 29, 37, 78 };

            Console.WriteLine(String.Join(",",a));

            /*int j = a.Length - 1;
            for(int i=0; i<a.Length/2; i++)
            {
                int temp = a[i];
                a[i] = a[j];
                a[j] = temp;
                j--;

            }

            Console.WriteLine(String.Join(",",a));*/

            /*int[] a = { 3, 90, 45, 29, 37, 78 };*/
            int j = a.Length - 1;
            for(int i=0; i<a.Length; i++)
            {
                a[i] = a[i] + a[j];
                a[j] = a[i] - a[j];
                a[i] = a[i] - a[j];
            }

            Console.WriteLine(String.Join(",",a));
            
        }
    }
}
