using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Food
    {
        public string type = "spicy";
    }



    class PavBhaji : Food
    {
       public void Display()
        {
            Console.WriteLine(type);

        }
    }

    class SingleDemo3
    {
        static void Main(string[] args)
        {
            PavBhaji v = new PavBhaji();
            v.Display();
        }
    }

}
