using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject
{
    class ArrayListProgram
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("Aadarsh");
            al.Add("Jayraj");
            al.Add("Siddhant");
            al.Add("Dheeraj");

            foreach(var x in al)
            {
                Console.WriteLine(x);
            }

        }
    }
}
