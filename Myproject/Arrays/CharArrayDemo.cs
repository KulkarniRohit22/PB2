using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class CharArrayDemo
    {
        static void Main(string[] args)
        {
            char[] ch = { 'e', 'A', 'T', 'U', 'f' };
           //3ways to display an array..
            foreach(char c in ch )
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("//////////////////////////////");
            Array.ForEach(ch, Console.WriteLine);

            Console.WriteLine("//////////////////////////");
            Console.WriteLine(String.Join(",",ch));

           
        }
    }
}
