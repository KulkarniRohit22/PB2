using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Topic2Assignment
{
    class Assignment11
    {
        //write  a programme to to create a simple calculator using switch case Menu driven programme.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter first number.");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number.");
            int num2 = Convert.ToInt32(Console.ReadLine());
            


            Console.WriteLine("////////////////////////////// MENU ///////////////////////////////");
            Console.WriteLine(" + for Addition \n - for  subtraction \n * for  Multiplication \n / for Division");

            Console.WriteLine("Enter your choice.");
            char op = Console.ReadLine()[0];
            

            switch (op)
            {
                
                 
                case '+':
                    Console.WriteLine("The addition of the two numbers is :" + (num1 + num2));
                    break;

                case '-':
                    Console.WriteLine("The subtraction of the two number is: " + (num1 - num2));
                    break;

                case '*':
                    Console.WriteLine("The multiplication of the two numbers is: " + (num1 * num2));
                    break;

                case '/':
                    Console.WriteLine("The division of the two numbers is:"+ (num1 / num2));
                    break;

                default:
                    Console.WriteLine("Invalid operator.");
                    break;
            }
           
        }
    }
}
