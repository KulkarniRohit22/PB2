using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class ArrayAllElementsSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            int size = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the elements in an array");
            int[] a = new int[size];
            int sum = 0;
            for(int i=0; i<a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
            }

            for(int i=0; i<a.Length; i++)
            {
                sum = sum + a[i];
            }
            Console.WriteLine("The sum of the array elements is: " + sum);
        }
    }
}
