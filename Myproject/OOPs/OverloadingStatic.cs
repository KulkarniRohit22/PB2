using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class OverloadingStatic
    {
        static void  arithmatic(int a ,int b)
        {
            Console.WriteLine("Addition is: " + (a + b));
            
        }

        static void arithmatic(float  x , float y)
        {
            Console.WriteLine("subtration is :" + (x-y));
        }
        static void arithmatic(int p,int q, int r)
        {
            Console.WriteLine("multi is : " + (p * q * r));
        }

        static void Main(string[] args)
        {
           OverloadingStatic.arithmatic(3,4);
           OverloadingStatic.arithmatic(8f,4f);
           OverloadingStatic.arithmatic(8,7,6);

        }
    }
}
