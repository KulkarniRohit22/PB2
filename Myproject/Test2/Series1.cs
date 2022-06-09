using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Test2
{
    class Series1
    {
        static void Main(string[] args)
        {
            int t;
            for(int i=1; i<=10; i++)
            {
                t = i * i - 1;
                Console.WriteLine(t);
            }
        }
    }
}
