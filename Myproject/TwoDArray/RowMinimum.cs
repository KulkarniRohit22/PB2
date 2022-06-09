using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TwoDArray
{
    class RowMinimum
    {
        static void Main(string[] args)
        {
            int[,] p = new int[,] { { 1, 2, 3 },{ 4, 5, 6 },{ 7, 8, 9 } };
           
            for(int i=0; i<p.GetLength(0); i++)
            {
                int min = p[i, 0];
                for(int j=0; j<p.GetLength(1);j++)
                {
                    if(min>p[i,j])
                    {
                        min = p[i, j];
                    }
                }
                Console.WriteLine("min " + min);
            }
        }
    }
}
