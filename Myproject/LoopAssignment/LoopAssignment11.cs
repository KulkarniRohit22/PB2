using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment11
    {
        static void Main(string[] args)
        {
            //print the table of the given number.

            Console.WriteLine("Enter the number.");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i=1; i<=10; i++)
            {
                Console.WriteLine("The table of given number is : " + num +" * " + i + "=" + (num * i)  );
            }
        }
        
    }
}
