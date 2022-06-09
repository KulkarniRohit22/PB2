using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class HwUniqueNumbersInArray
    {
        static void Main(string[] args)
        {
            int[] x = { 1, 2, 3, 4, 4, 5, 2, 6, 7, 8 };

            Console.WriteLine(String.Join(",",x));

            for (int i = 0; i < x.Length; i++)
            {
                int count = 1;

                bool IsVisited = false;
                for (int k = i - 1; k >= 0; k--)
                {
                    if (x[i] == x[k])
                    {
                        IsVisited = true;
                        break;
                    }
                }
                if (IsVisited == false)
                {
                    for (int j = i + 1; j < x.Length; j++)
                    {
                        if (x[i] == x[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(x[i] + " " + count);
                    }
                }
            }   
        }
    }
}
