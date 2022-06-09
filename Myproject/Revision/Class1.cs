using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    interface IWishable
    {
        void greet(string msg);
    }
    interface IMaths
    {
        void add(int a, int b);
        int Divide(int x,int  y);

    }
    class class1:IMaths
    { 
        public void wishable(string msg)
        {
            Console.WriteLine("Hello , Good morning" + msg);
        }
       public void add(int a,int b)
       {
            Console.WriteLine("The addition is: " + (a+b) );
       }
       public int Divide(int x, int y)
       {
            int r = x / y;
            return r;
       }

        static void Main(string[] args)
        {
            IMaths im = new class1();
            im.add(90, 10);
           int ans= im.Divide(36, 6);
            

            Console.WriteLine(ans);

        }
    }

}
