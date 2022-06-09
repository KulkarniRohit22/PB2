using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class TernaryComparingThreeNumbers
    {
        static void Main(string[] args)
        {
            int num1, num2, num3;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter third number: ");
            num3 = Convert.ToInt32(Console.ReadLine());


            int result = num1 > num2 && num1 > num3 ? num1 : num2 > num3 ? num2 : num3;
            Console.WriteLine("Result" + result);
        }
    }
}
