using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Fruits
    {
        public string color = "red";
    }



    class apple: Fruits
    {
        
        public void show()
        {
            Console.WriteLine(color);
        }
    }

    class SingleDemo1
    {
        static void Main(string[] args)
        {
            apple a = new apple();
            a.show();
        }
    }
}
