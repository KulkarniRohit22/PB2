using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class ReverseWithoutLoop
    {
        static void reverse(string str)
        {
            if(str != " ")
            {
                Console.Write(str[str.Length-1]);  //d, a, s,a,r,p
                reverse(str.Substring(0, str.Length - 1));
            }

        }

        static void Main(string[] args)
        {
            reverse("Prasad");
            
        }
    }
}
