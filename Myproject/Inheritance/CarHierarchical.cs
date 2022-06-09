using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Inheritance
{
    class CarHierarchical
    {
        protected int enginepower = 0;

        void myCar()
        {
            Console.WriteLine(enginepower);
        }
    }

    class BMW : CarHierarchical
    {
        public void Show()
        {
            enginepower = 700;
            Console.WriteLine("BMW enginepower" + enginepower);
        }
    }


   class Audi : CarHierarchical
    {
        public void Display()
        {
            enginepower = 1200;
            Console.WriteLine("Audi enginepower:" + enginepower);
        }
    }



    class AstonMartin : CarHierarchical
    {
        public void Print()
        {
            enginepower = 3000;
            Console.WriteLine("Aston Martin enginepower:" +enginepower);
        }
    }


    class MyCar
    {
        static void Main(string[] args)
        {
            BMW b = new BMW();
            Audi a = new Audi();
            AstonMartin m = new AstonMartin();
            b.Show();
            a.Display();
            m.Print();
        }
    }
}
