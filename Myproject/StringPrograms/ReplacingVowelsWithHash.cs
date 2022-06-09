using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.StringPrograms
{
    class ReplacingVowelsWithHash
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            string replace = " ";
            char[] s = str.ToLower().ToCharArray();

            for (int i = 0; i < s.Length; i++)
            {

                if (s[i] == 'a' || s[i] == 'e' || s[i] == 'i' || s[i] == 'o' || s[i] == 'u')
                {
                    replace += '#';
                }
                else 
                {
                    replace += s[i];
                }


            }
            Console.WriteLine("The numbers of vowels present : " + replace);
        }
    }
}
