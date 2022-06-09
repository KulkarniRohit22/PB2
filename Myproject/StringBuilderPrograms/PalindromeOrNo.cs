using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.StringBuilderPrograms
{
    class PalindromeOrNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string .");
            string str = Console.ReadLine();
            string reverse = " ";

            for(int i=str.Length-1; i>=0; i--)
            {
                reverse = reverse + str[i].ToString();
            }
            if(reverse.CompareTo(str)==0)
            {
                Console.WriteLine("String is palindrome");
            }
            else
            {
                Console.WriteLine("String is not palindrome.");
            }
        }
    }
}
