using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class ZeroAndNonZeroArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[] { 2, 0, 14, 0, 5, 20, 6, 0, 0 };

            for(int i=0; i<a.Length; i++)
            {
                for(int j=i+1; j<a.Length; j++)
                if(a[i] == 0 && a[j] !=0)
                {
                    int temp = a[i];
                        a[i] = a[j];
                        a[j] = temp;
                }
            }
            Console.WriteLine("////////////////////");
            Console.Write(String.Join(",",a));
        }
    }
}
