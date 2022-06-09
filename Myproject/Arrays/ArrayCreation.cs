using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class ArrayCreation
    {
        static void Main(string[] args)
        {
            int[] marks = { 34,12,64,3,4};
            int[] mark = new int[] { 34, 12, 64, 3, 4 };
            int[] a = new int[5];
            a[0] = 32;
            a[1] = 12;
            a[2] = 64;
            a[3] = 3;
            a[4] = 4;

            // 3 Methods to display array.
            Console.WriteLine("Enter the Array Elements");
            for(int i=0; i<a.Length; i++ )
            {
                int x = Convert.ToInt32(Console.ReadLine());
                a[i] = x;
            }
            Console.WriteLine("/////////////////////////////////////////");
            for(int i=0; i<a.Length; i++)
            {
                Console.Write(a[i]+" ");
            }
            Console.WriteLine();

            Console.WriteLine("//////////////////////////////////////////");

            foreach(int c in a)
            {
                Console.Write(c+" ");
            }
            //Console.WriteLine();
        }
    }
}
