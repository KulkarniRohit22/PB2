using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Test3
{
    class Question13
    {
        static void Main(string[] args)
        {
            for(int i=1; i<=50; i++)
            {
                int count1 = 0;
                if (i % 3 == 0)
                {
                    Console.WriteLine("Buzz");
                    count1++;
                }
                Console.WriteLine(count1);
            }
            /*for(int i=1; i<=50; i++)
            { 
                int count2 = 0;
                 if (i % 5 == 0)
                {
                    Console.WriteLine("Fizz");
                    count2++;
                }
                
            }
            for(int i=0; i<=50; i++)
            {
                int count3 = 0; 
                 if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("BuzzFizz");
                    count3++;
                }
                else
                {
                    Console.WriteLine(i);
                }
            }*/
            
          
        }
    }
}
