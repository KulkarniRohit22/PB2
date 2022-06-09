using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class TableOfNumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(".........................");
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(num+" * "+i+" = "+(num*i));
            }
        }
    }
}
