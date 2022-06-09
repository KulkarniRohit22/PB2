using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TwoDArray
{
    class ColumnSum
    {
        static void Main(string[] args)
        {
            int[,] a = { { 1, 2, 3 }, 
                         { 4, 5, 6 }, 
                         { 7, 8, 9 } };

            for(int j=0; j<a.GetLength(0); j++)
            {
                int sum = 0;
                for(int i=0; i<a.GetLength(1); i++)
                {
                    sum = sum + a[i, j];
                }
                Console.WriteLine(String.Join(",", sum));
            }
          
        }
    }
}
