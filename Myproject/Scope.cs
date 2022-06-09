using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class Scope
    {
        static void Main(string[] args)
        {
            int a = 25;
            int age = 29;
            int no = 8;
           if(age> 18 && no <11 )
            {
                a = 25;
            }
            Console.WriteLine(a);
        }
    }
}
