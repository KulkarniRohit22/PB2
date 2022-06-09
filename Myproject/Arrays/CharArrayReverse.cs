using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class CharArrayReverse
    {
        static void Main(string[] args)
        {
            /*char[] ch = { 'a', 'b', 'c', 'd' };
            Console.WriteLine(String.Join(",", ch));*/
            /* Array.ForEach (ch,Console.WriteLine);
             Console.WriteLine("//////////////////////////////////////////");
             for(int i=ch.Length-1; i>=0; i--)
             {
                 Console.WriteLine(ch[i]+" ");
             }
             Console.WriteLine(String.Join(",", ch));
             Console.WriteLine("//////////////////////////////////////");*/

            char[] ch = { 'a', 'b', 'c', 'd' };
            Console.WriteLine(String.Join(",", ch));
            int j = ch.Length - 1;
            for (int i = 0; i < ch.Length / 2; i++)
            {
                char temp = ch[i];
                ch[i] = ch[j];
                ch[j] = temp;
                j--;
                
            }
            Console.WriteLine("///////////////////////////////////");


            for (int i = 0; i < ch.Length; i++)
            {
                Console.WriteLine(ch[i] + "  ");
            }

        }
    }
}
