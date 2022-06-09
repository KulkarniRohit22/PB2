using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class swapping
    {
        static void Main(string[] args)
        {
            int a = 5, b = 10;
            Console.WriteLine("Before swapping a= " + a + " b= " + b);
            a = a * b;       
            b = a / b;       
            a = a / b;    
            Console.Write("After swapping a= " + a + " b= " + b);
        }
    }
}
