using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class TernaryPositiveNegative
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());
            

            string result = num > 0 ? "positive":num<0?"negative":"zero";
            Console.WriteLine(result);

        }
    }
}
