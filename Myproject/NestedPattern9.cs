using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedPattern9
    {
        static void Main(string[] args)
        {
            for (char i = 'A'; i <= 'D'; i++)
            {
                for (char j = 'D'; j >=i; j--)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
