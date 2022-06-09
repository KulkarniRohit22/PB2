using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.ExceptionHandlingPrograms
{
    class NullReferenceExceptionDemo
    {

       public static string name;
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the name which contains less than 4 elements");
            string str = Console.ReadLine();
            Console.WriteLine("Enter a number");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine("The 6th element of string" + str[6]);
                Console.WriteLine("Division=" + (num1 / num2));
               

                //Console.WriteLine(name.ToCharArray());//it will give you a NullReferenceException 
                                                  //because if you do not put any value inside a
                                                  //non Primitive so that means its reference object will not be able to 
                                                  //point the value where it is stored. so it will give you a exception.
            }
            catch(NullReferenceException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Null reference exception occured");
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Index out of bound");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (SystemException e)
            {
                Console.WriteLine(e.Message);
            }
        }
           
        
    }
}
