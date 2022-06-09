using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedPattern15
    {
        static void Main(string[] args)
        {
           
            for (int i = 1; i <= 5; i += 2)
            {
                for (int k = 5; k > i; k -= 2)
                { 
                    Console.Write(" "); 
                }
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }

            Console.WriteLine();
            }
            for (int i = 7; i >= 0; i -= 2)
            {

                for (int k = 5; k > i; k -= 2)
                {
                    Console.Write(" ");
                }

            }
            Console.Read();
        }
    }
}
