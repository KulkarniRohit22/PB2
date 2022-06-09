using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class Revision
    {
        static void Main(string[] args)
        {
            string str = "Reverse Me!";


            StringBuilder sb = new StringBuilder(str);

            for (int i = str.Length - 1; i >= 0; i--)
            {
                sb.Append(sb[i]);
                Console.Write(sb[i]);

            }
            Console.WriteLine("   ");
            string str2 = sb.ToString();
            if (str == str2)
            {
                Console.WriteLine(" string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }



           
        }
    }
}
