using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TwoDArray
{
    class ColumnMaximum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the size of an array");
            int size = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the size of an array");
            int size1 = Convert.ToInt32(Console.ReadLine());
            int[,] a = new int[size,size1];

            Console.WriteLine("Enter the elements of an array");
            for(int i=0;i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            for(int j=0; j<a.GetLength(1); j++)
            {
                int max = a[0, j];
                for (int i = 0; i < a.GetLength(0); i++)
                {
                    if (max < a[i, j])
                    {
                        max = a[i, j];
                    }
                  
                }
                Console.WriteLine("The maximum numbers in column are: " +max);
            }

        }
    }
}
