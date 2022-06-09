using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class ArrayEvenSum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of the array.");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] s = new int[size];
            int sum = 0;

            Console.WriteLine("Enter the elements in an array.");
            for(int i=0; i< s.Length; i++ )
            {
                 s[i] = Convert.ToInt32(Console.ReadLine());

            }

            for(int i=0; i<s.Length; i++)
            {
                if(s[i] % 2 == 0)
                {
                    sum = sum + s[i];
                }
            }
            Console.WriteLine("The sum od even number is: " +sum);
        }
    }
}
