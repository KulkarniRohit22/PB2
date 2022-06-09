using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TwoDArray
{
    class TwoDArrayAddition
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] Addition = new int[3,3];

            Console.WriteLine("Enter the elements in array a.");

            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("Enter the elements in array b.");
            for (int i = 0; i < b.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    b[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("//////////////////////////");



            Console.WriteLine("////////////////////////////");


            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < b.GetLength(1); j++)
                {
                    Addition[i, j] = a[i, j] + b[i, j];
                }
            }

            Console.WriteLine("...........................................");


            for (int i = 0; i < Addition.GetLength(0); i++)
            {
                for (int j = 0; j < Addition.GetLength(1); j++)
                {
                    Console.WriteLine(Addition[i, j] + " ");
                }
            }
        }
    }
}
