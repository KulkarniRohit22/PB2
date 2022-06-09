using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class EvenPosition
    {
        static void Main(string[] args)
        {

            int[] a = new int[5];
            int sum = 0;
            Console.WriteLine("Enter Array elements");
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());

            }

            for(int i = 0; i<a.Length; i++)
            {
                if(i % 2 ==0)
                {
                    sum = sum + a[i];
                }

            }
            Console.WriteLine("The sum of Even Position : " +sum);
        }
    }
}
