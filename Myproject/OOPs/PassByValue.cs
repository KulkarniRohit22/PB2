using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class PassByValue
    {
        void swapByRef(ref int x, ref int y)
        {
            Console.WriteLine("Before swap in swap method ==" +x + " " + y);
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After the swap in swap method " + x + " " + y);
        }

        void swapByValue(int x, int y)
        {
            Console.WriteLine("Before the swap in swap method " + x + " " + y );
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine("After the swap in swap method " + x + " " + y );
        }

        static void Main(string[] args)
        {
            PassByValue p = new PassByValue();
            Console.WriteLine("Enter the num1");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            int num2 = Convert.ToInt32(Console.ReadLine());

            p.swapByRef(ref num1, ref num2);
            Console.WriteLine("After swap in main " +num1 + " " + num2);

            Console.WriteLine("//////////////////////////////////////////////");

            p.swapByValue(num1, num2);
            Console.WriteLine("After swap in Main "+ num1 + " " + num2);
        }
    }
}
