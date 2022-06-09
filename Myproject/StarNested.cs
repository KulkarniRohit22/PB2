using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class StarNested
    {
        static void Main(string[] args)
        {
            int i, j, k;
            for (i = 1; i <= 5; i += 2)
            { 
                for (k = 5; k > i; k -= 2)
                { Console.Write("  "); }
                for (j = 0; j < i; j++) 
                { 
                    Console.Write(" *"); 
                }
               
                Console.Write("\n"); 
            }
            for (i = 7; i >= 0; i -= 2)
            {
            
                for (k = 5; k > i; k -= 2)
                { 
                    Console.Write("  ");
                }
               
            }
            Console.Read();
        }

    }
}







