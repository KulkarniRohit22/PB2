using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class HwSortingArrayAscending
    {
        static void Main(string[] args)
        {
            int[] m = { 29, 64, 39, 56, 79, 98 };

            Console.WriteLine(String.Join(",", m));


            for(int i=0; i<m.Length; i++)
            {
                for(int j =i+1;j<m.Length; j++)
                {
                    if (m[i] > m[j]) //if you want to perform ascending sorting always do it with
                                       // adjecent element
                    {
                        int temp = m[i];
                        m[i] = m[j];
                        m[j] = temp;
                    }

                }
            }
            Console.WriteLine("The sorted array in ascending order"+ m);
            /*foreach(int asc in m)
            {
                Console.WriteLine(asc);
            }*/
        }

    }
}
