using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchDemo
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Enter a number: ");
            num = Convert.ToInt32(Console.ReadLine());


            switch (num)
            {
                case 1: Console.WriteLine("One");
                    break;
                case 2:Console.WriteLine("Two");
                    break;
                case 3:Console.WriteLine("Three");
                    break;
                case 4:Console.WriteLine("Four");
                    break;
                case 5:Console.WriteLine("Fifth");
                    break;
                default: Console.WriteLine("Invalid input");
                    break;

            }
        }
    }
}
