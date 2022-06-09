using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ExceptionHandlingPrograms
{
    class ExceptionHandlingDemo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your age");
            try
            {
                int age = int.Parse(Console.ReadLine());

                Console.WriteLine("Name= " + name + "Age=" + age);
                Console.WriteLine("Charcter at the 5th position is: " +name[4]);
                try
                {
                    Console.WriteLine("Enter 2 numbers");
                    int a = int.Parse(Console.ReadLine());//12
                    int b = int.Parse(Console.ReadLine());//om
                    Console.WriteLine("Division=" + (a / b));
                }
                catch(DivideByZeroException e)
                {
                    Console.WriteLine(e.Message);
                }
                //as we do not have a format exception in inner try catch..it will check if
                //its parent has it or not..if its parent class has it then it will use that 
                //catch block...so even if inner try do not have FormatException the program will
                // not exit abruptly.

            }
            catch(FormatException e)
            {
                Console.WriteLine("Enter a numeric value");
            }
            catch(IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
            }
            catch(SystemException e)
            {
                Console.WriteLine(e.Message);
            }
            for(int i=0; i<=5; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

    class A
    {
        static void divide(int a, int b)
        {
            Console.WriteLine("Division : " +(a /b));//either you can put a try catch block here or in main method. the clr will 
                                                     //see if you have used try catch in the method if you havent,then it will check
                                                     //if you have written it in the main method from where you are calling your divide
                                                     //method if you have put there a try catch bloke then it will not abrubptly exit the code.
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            try
            {
                divide(10, 0);
            }
            catch(DivideByZeroException e)
            {
                Console.WriteLine("in the main exception is handled");
                Console.WriteLine(e.Message);
            }
        }
    }
    class B
    {
        static int division(int a, int b)
        {
            try
            {
                Console.WriteLine("in division");
                return a / b;
            }
            catch(DataMisalignedException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("in finally");
            }
            return 0;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Main starts");
            int result = division(10, 2);
            Console.WriteLine("Answer: " + result);
            Console.WriteLine("Main ends");
        }
    }

    
}
