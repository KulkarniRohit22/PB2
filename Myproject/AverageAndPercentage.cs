using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class AverageAndPercentage
    {
        static void Main(string[] args)
        {
            int mathematics = 78;
            int biology = 89;
            int microprocessor = 90;
            int physics = 68;
            int chemistry = 70;
            int total,average,percentage;

            total = mathematics + biology + microprocessor + physics + chemistry;
            Console.WriteLine("Total marks obtained: " + total);
            percentage = (total / 500) * 100;
            Console.WriteLine("The percentage is: " + percentage);
            average = (total) / 5;
            Console.WriteLine("The average is: " + average);
           
        }

    }
}
