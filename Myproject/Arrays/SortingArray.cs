using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class SortingArray
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array.");
            int size = Convert.ToInt32(Console.ReadLine());
            int[] s = new int[size];

            Console.WriteLine("Enter the elements of the array.");
            for(int i=0; i<s.Length; i++ )
            {
                s[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(String.Join(",",s));

            for(int i=0; i<s.Length; i++)
            {
                for(int j=i+1; j<s.Length; j++)
                {
                    int temp = s[i]; 
                    s[i] = s[j];
                    s[j] = temp;
                }
            }
            Console.WriteLine("//////////////////////////////");
            Console.WriteLine(String.Join(",",s));
        }
    }
}
