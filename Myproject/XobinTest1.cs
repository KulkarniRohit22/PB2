using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class XobinTest1
    {
        static void Main(string[] args)
        {
             Console.WriteLine("Enter a number.");
             int num = Convert.ToInt32(Console.ReadLine());
             bool IsPrime = true;

             for(int i=2; i < num/2; i++ )
             {
                 if(num % i ==0)
                 {
                     IsPrime = false;
                     break;
                 }
             }
             if(IsPrime)
             {
                 Console.WriteLine("The number is prime");
             }
             else
             {
                 Console.WriteLine("The number is not prime.");
             }
        }
    }
}
