using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class MaxElements
    {
        static void Main(string[] args)
        {
            char[] ch = { 'a', 'b', 'z', 'd' };

            char max = ch[0];

            for(int i=0; i<ch.Length; i++)
            {
                if(max<ch[i])
                {
                    max = ch[i];
                }
            }
            Console.WriteLine("the maximum element is:" +max);
        }
    }
}
