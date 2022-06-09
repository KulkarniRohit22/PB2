using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class OverLoadArea
    {
        void area(int r, int PI)
        {
            Console.WriteLine("The area of circle is : " +(PI * (r * r)));
        }
        void area(float len,int width)
        {
            Console.WriteLine("The area of rectangle is : " +(2 *(len * width)));
        }
        void area(int a)
        {
            Console.WriteLine("The area of square is : " +(a * a));
        }
        void area(double b, double h)
        {
            Console.WriteLine("The area of triangle is : " + ((b * h) / 2));
        }

        static void Main(string[] args)
        {
            OverLoadArea o = new OverLoadArea();
            o.area(4, 3.14);
            o.area(3f, 5);
            o.area(5);
            o.area(3,8);

        }
    }
}
