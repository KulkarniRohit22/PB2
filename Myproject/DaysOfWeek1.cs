using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class DaysOfWeek1
    {
        static void Main(string[] args)
        {
            char day;
            Console.WriteLine("Enter a name of the day: ");
            day = Convert.ToChar(Console.ReadLine()[0]);

            if(day == 's' )
            {
                Console.WriteLine("The day is weekends");
            }
            else
            {
                Console.WriteLine("the day is weekday.");
            }

        }
    }
}
