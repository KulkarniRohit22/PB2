using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class MethodDemo
    {
        public void show_Data() //Method declaration
        {
            Console.WriteLine("I am show!!"); //Method body
        }

        public void addition(int a,int b)
        {
            Console.WriteLine("Addition" + (a + b));
        }
        public string myFoo()
        {
            return "Hello";
        }

        public float areaOfCircle(int r,float PI)
        {
            float area = PI * r * r;
            return area;
        }




        static void Main(string[] args)
        {
            MethodDemo s = new MethodDemo();
            s.show_Data();//Method call
            s.addition(7, 5);
            /* string str = s.muFoo();
            Console.WriteLine(str);*/
            Console.WriteLine(s.myFoo());

            float a = s.areaOfCircle(4, 3.14f);
            Console.WriteLine("Area of Circle: " +a);
        }
    }
}
