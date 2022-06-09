using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment12
    {
        //Print the squares of 1 to 20;

        static void Main(string[] args)
        {
            int square = 1;
            Console.WriteLine("The squares of 1 to 20 numbers are: ");

            for(int i=1; i<=20; i++)
            {
                square = i * i;

                Console.WriteLine(square);
            }
        }
    }
}
