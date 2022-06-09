using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class ForEachSumOfEven
    {
        //Write a programme to display the sum of the even numbers using ForEach.

        static void Main(string[] args)
        {
            int[] a = new int[5];
            int sum = 0;
            Console.WriteLine("Enter Array elements");
            for(int i=0; i<a.Length; i++)
            {
                a[i] = Convert.ToInt32(Console.ReadLine());
                

            }
            foreach(int x in a)
            {
               
                if(x % 2==0)
                {
                    sum = sum + x;
                   
                }
                
               
            }
            Console.WriteLine("The sum of the even number is : " + sum);

        }
    }
}
