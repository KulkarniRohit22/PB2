using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class CrossPatternArray
    {
        static void Main(string[] args)
        {
            int[,] m = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for (int i = 0; i < m.GetLength(0); i++)
            {
                for (int j = 0; j < m.GetLength(1); j++)
                {
                    if (j == (m.GetLength(1) - 1 - i)  || i == j)
                    {
                        Console.Write(m[i, j] + "  ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }

                }
                Console.WriteLine();
            }
        }
    }
}
