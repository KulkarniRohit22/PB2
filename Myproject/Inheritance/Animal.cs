using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class Animal
    {
        public int legs = 4;
    }

    class Cat : Animal
    {
        public void show()
        {
            Console.WriteLine(legs);
        }
    }


    class SingleDemo
    {
        static  void Main(string[] args)
        {
            Cat c = new Cat();
            c.show();
        }
    }

}
