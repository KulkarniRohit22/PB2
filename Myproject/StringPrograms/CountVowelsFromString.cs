using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.StringPrograms
{
    class CountVowelsFromString
    {
        static void Main(string[] args)
        {
            string str = "India is my country";
            int count = 0;
            char[] s = str.ToLower().ToCharArray();

            for (int i=0; i<s.Length; i++)
            {
               
                if(s[i] =='a' || s[i] == 'e' || s[i]=='i' || s[i] == 'o' || s[i] == 'u' )
                {
                    count++;
                }


            }
            Console.WriteLine("The numbers of vowels present : " + count);
        }
    }
}
