using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class PatternTwoDArray
    {
        static void Main(string[] args)
        {
            int[,] m = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

            for(int i=0; i<m.GetLength(0); i++)
            {
                for(int j=0; j<m.GetLength(1); j++)
                {
                    if (j == 0 || i==j  || j == m.GetUpperBound(1))
                    {
                        Console.Write(m[i, j] +"  ");
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
