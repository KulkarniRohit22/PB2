using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class StringAnagram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string");
            string s1 = Console.ReadLine();

            Console.WriteLine("Enter another string.");
            string s2 = Console.ReadLine();

            char[] ch1 = s1.ToLower().ToCharArray();
            char[] ch2 = s2.ToLower().ToCharArray();

            Array.Sort(ch1);
            Array.Sort(ch2);

            Console.WriteLine(String.Join(",",ch1));
            Console.WriteLine(String.Join(",",ch2));

            string p1 = new string(ch1);
            string p2 = new string(ch2);

            if(p1.CompareTo(p2)==0)
            {
                Console.WriteLine("The string is anagram.");
            }
            else
            {
                Console.WriteLine("The string is not an anagram.");
            }
        }
    }
}
