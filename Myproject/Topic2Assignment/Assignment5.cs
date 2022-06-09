using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Topic2Assignment
{
    class Assignment5
    {
        //Write a programme to create a simple calculator.
        static void Main(string[] args)
        {
            Console.WriteLine("ENter a number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ENter an operator.");
            char op = Console.ReadLine()[0];

            if(op == '+')
            {
                Console.WriteLine("The addition od the two number is: " +num1 + num2);
            }
            else if(op == '-')
            {
                Console.WriteLine("The subtraction of the two number is: " + (num1 - num2));
            }
            else if(op == '*')
            {
                Console.WriteLine("The multiplication of the two number is : " + (num1 * num2));
            }
            else if(op == '/')
            {
                Console.WriteLine("The division of the two number is : " + (num1 / num2));
            }
            else
            {
                Console.WriteLine( "Invalid operator!!");
            }
        }
    }
}
