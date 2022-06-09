using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class SimpleInterest
    {
        static void Main(string[] args)
        {
            int p = 5000;
            int r = 15;
            int t = 1;
            int SI;

            SI = (p * r * t) / 100;
            Console.WriteLine(SI);
        }
    }
}
