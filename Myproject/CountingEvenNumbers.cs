using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class CountingEvenNumbers
    {
        static void Main(string[] args)
        {
            int i;
            int count = 0;
            for(i=1; i<=20; i++)
            {
                if(i % 2 == 0)
                {
                    count = count + 1;
                    
                    
                }
                
            }
            Console.WriteLine("The count of even numbers is :" + count);
        }
    }
}
