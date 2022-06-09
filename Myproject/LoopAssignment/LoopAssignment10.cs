using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.LoopAssignment
{
    class LoopAssignment10
    {
        //find all prime numbers between 400 to 300
        static void Main(string[] args)
        {
            int count = 0;
            for (int i = 400; i >= 300; i--)
            {

                count = 0;
                if (i > 0)
                {
                    for (int j = 2; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            count = 1;
                            break;
                        }

                    }

                    if (count == 0)
                    {
                        Console.WriteLine(i + "  ");

                    }
                }

            }
        }

    }
}
