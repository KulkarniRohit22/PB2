using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.StringPrograms
{
    class StringReverse
    {
        static void Main(string[] args)
        {
            string str = "India is my country.";
            string reverse = "  ";
            /*
                        for(int i=0; i<str.Length;i++)
                        {
                            reverse = str[i] + reverse;
                        }
                        Console.WriteLine(reverse);*/


            for (int i = str.Length - 1; i >= 0; i--)
            {
                reverse = reverse + str[i];
            }
            Console.WriteLine(reverse);
        }
    }
}
