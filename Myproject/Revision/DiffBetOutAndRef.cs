using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class DiffBetOutAndRef
    {
        static void m1(int a , int b)
        {
            a = a + 10;
            b = b + 10;
        }
        static void Main(string[] args)
        {
            int x = 10; int y = 20;
           /* DiffBetOutAndRef.m1(out x, out y);*/
        }
    }
}
