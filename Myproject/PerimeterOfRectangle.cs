using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class PerimeterOfRectangle
    {
        static void Main(string[] args)
        {
            int length = 10;
            int breadth = 20;
            int perimeter;

            perimeter = 2 * (length + breadth);
            Console.WriteLine(perimeter);
        }
    }
}
