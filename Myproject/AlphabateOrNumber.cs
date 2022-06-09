using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class AlphabateOrNumber
    {
        static void Main(string[] args)
        {
            char ch;
            Console.WriteLine("Enter the character: ");
            ch = Convert.ToChar(Console.ReadLine()[0]);

            if ((ch >= 'a' && ch <= 'z') || (ch >= 'A' && ch <= 'Z'))
            {
                Console.WriteLine(ch + "is an Alphabet. ");
            }
            else if (ch >= '0' && ch <= '9')
            {
                Console.WriteLine(ch + "is a Number. ");
            }
            else 
            {
                Console.WriteLine("symbol");
            }
        }
    }
}
