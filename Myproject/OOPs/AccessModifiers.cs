﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.OOPs
{
    class AccessModifiers
    {
        private int x = 10;
        protected int y = 20;
        public int z = 40;

        static void Main(string[] args)
        {
            AccessModifiers a = new AccessModifiers();
            Console.WriteLine(a.x);
            Console.WriteLine(a.y);
            Console.WriteLine(a.z);
        }
    }

    class Info : AccessModifiers
    { 
        void print()
        {
        AccessModifiers a = new Info();
           // Console.WriteLine(a.x); //error becoz private is not access outside the class
            //Console.WriteLine(a.y);
            Console.WriteLine(a.z);
            Info n = new Info();
            //Console.WriteLine(a.x);
            Console.WriteLine(n.y);
            Console.WriteLine(n.z);

        }
    }
}
