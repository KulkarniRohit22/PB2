using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SwitchCalculator
    {
        static void Main(string[] args)
        {
            int num1, num2;
            char op;
            Console.WriteLine("Enter first number: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter second number: ");
            num2 = Convert.ToInt32(Console.ReadLine());
            op = Console.ReadLine()[0];

            switch (op)
            {
                case '+': Console.WriteLine("Addition =" +(num1 + num2));
                    break;
                case '-':
                    Console.WriteLine("Substraction =" + (num1 - num2));
                    break;
                case '*':
                    Console.WriteLine("Multiplication =" + (num1 * num2));
                    break; 
                case '/':
                    Console.WriteLine("Divition =" + (num1 / num2));
                    break;
                case '%':
                    Console.WriteLine("Modulus =" + (num1 % num2));
                    break;
                default: Console.WriteLine("Invalid Operator.");
                    break;

            }
        }
    }
}
