using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Box
    {
        int length;
        int breadth;
        int height;
        //int area;
        int a;

        static void Main(string[] args)
        {
            Box s1 = new Box();
            s1.length = 3;
            s1.breadth = 3;
            s1.height = 3;
            s1.a = s1.length = s1.breadth = s1.height;
            int area = 6 * (s1.a *s1.a);
            Console.WriteLine("The area of the box is:" + area);
        }
    }
}
