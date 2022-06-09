using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class HwMinCharacterInArray
    {
        static void Main(string[] args)
        {
            char[] ch = { 'A', 'D', 'E', 'x', 'z', 'R'};

            Console.WriteLine(String.Join(",",ch));
            char min = ch[0];
            for (int i = 0; i < ch.Length; i++)
            {
                if (min > ch[i])
                {
                    min = ch[i];
                }
            }
            Console.WriteLine("The min element is: " + min);
        }
    }
}
