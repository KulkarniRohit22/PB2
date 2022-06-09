using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
     static class Addition
     {
        static int num1 = 10;
        static int num2 = 20;
        static int result;

 

         static Addition()
         {
            Console.WriteLine("This is a default constructor");
            
         }

        static void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
        }

        static void Main(string[] args)
        {
            Addition.Add();
        }
     }

    
}
