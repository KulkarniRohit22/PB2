using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class DivisibleBy5And11
    {
        static void Main(string[] args)
        {
            int five = 0;
            int eleven = 0;
            for(int i=1; i<=50; i++)
            {
                five = i / 5;
               // eleven = i / 11;
                Console.WriteLine("The numbers that are divisible by 5 are: " +five);
               // Console.WriteLine(eleven);
            }
            
        }
    }
}
