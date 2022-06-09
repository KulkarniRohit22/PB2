using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class YoungerOlder
    {
        static void Main(string[] args)
        {
            int children;
            Console.WriteLine("Enter number of children: ");
            children = Convert.ToInt32(Console.ReadLine());
           

            if (children == 1)
            {
                Console.WriteLine("the only child.");
            }
            else 
            {
                Console.WriteLine("The person is oldest child.");
            }
        }
    }
}
