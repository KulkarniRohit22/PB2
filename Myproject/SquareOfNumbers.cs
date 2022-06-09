using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SquareOfNumbers
    {
        static void Main(string[] args)
        {
            int square = 1;
            for (int i = 1; i <= 15; i++)
            {
                square = i * i;
                Console.WriteLine(square);
            }
        }
    }
}
