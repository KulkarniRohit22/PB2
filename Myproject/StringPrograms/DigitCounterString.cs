using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.StringPrograms
{
    class DigitCounterString
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the string");
            int str = Convert.ToInt32(Console.ReadLine());
            int count = 0;

            for(int i=0; i<str; i++)
            {
                if(str>=0 && str <= 9)
                {
                    count++;
                }
            }
            Console.WriteLine("The digit count is: " + count);
        }
    }
}
