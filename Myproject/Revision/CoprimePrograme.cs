using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class CoprimePrograme
    {
        static void Main(string[] args)
        {
            //coprime pair we have to find out 
            int a = 10;
            //(1,15)
            int j;
            for (int i = 1; i <= a; i++)
            {
                int c = 0;  
                for (j = 1; j <= i; j++)
                {
                    if (a % j == 0 && i % j == 0)
                    {
                        c++;
                    }
                }
                if (c == 1)
                {
                    Console.WriteLine($"Given number is pair of co prime number{i} {a}");
                }
            }
        }
    }
}
