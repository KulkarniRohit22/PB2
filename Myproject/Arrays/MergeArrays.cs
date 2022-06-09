using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class MergeArrays
    {
        static void Main(string[] args)
        {
            int[] a = { 11, 22, 33, 44 };
            int[] b = { 10, 20, 30, 40 };
            int[] c = new int[a.Length + b.Length];

            int k = 0;
            for(int i=0; i<a.Length; i++)
            {
                c[k] = a[i];
                k++;
            }

            for(int j=0; j<b.Length; j++ )
            {
                c[k] = b[j];
                k++;
            }
            for(int i=0;i<c.Length; i++)
            {
                Console.WriteLine(c[i]);
            }
        }
    }
}
