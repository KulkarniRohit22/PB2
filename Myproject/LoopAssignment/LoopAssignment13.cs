using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment13
    {
        // accept the base and index from the user and calculate the power.

        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value of the base.");
            int base1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value of the index.");
            int index = Convert.ToInt32(Console.ReadLine());
            int power = 1;
            int i = 1;

            while ( i <= index)
            {
                power = base1 * power;
                i++;
                
            }
            Console.WriteLine(power);


        }
    }
}
