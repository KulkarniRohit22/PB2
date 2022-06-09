using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.TwoDArray
{
    class TwoDArrayDemo
    {
        static void Main(string[] args)
        {
            // int[][] a = new int[2][2];  how to declare array in another languages.
            int[,] a = new int[2, 2];//.Net decalration.
            /*a[0, 0] = 12;  //while assigning the value always start with the row.
            a[0, 1] = 64;
            a[1, 0] = 34;
            a[1, 1] = 65;*/

            Console.WriteLine("Enter the Array Elements.");

            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine("/////////////////////////////////////////////////");

            for(int i=0; i<a.GetLength(0); i++)
            {
                for(int j=0; j<a.GetLength(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("///////////////////////////////////////////////////");

            foreach(int x in a)
            {
                Console.Write(x+ " ");
            }
            Console.WriteLine();

            Console.WriteLine("////////////////////////////////////////////////////////");

            for(int i=0; i<=a.GetUpperBound(0); i++)
            {
                for(int j=0; j<=a.GetUpperBound(1); j++)
                {
                    Console.Write(a[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
