using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Arrays
{
    class MergingUniqueElements
    {
        static void Main(string[] args)
        {
            int[] p = { 1, 2, 3, 4, 5, 6, 7 };
            int[] q = { 6, 7, 8, 9, 10 };
            int[] r = new int[p.Length + q.Length];
            bool IsVisited = false;
            int count = 1;

            int z = 0;
            for(int i=0; i<p.Length; i++)
            {
                r[z] = p[i];
                z++;
                

            }
            for(int j=0; j<q.Length; j++)
            {
                r[z] = q[j];
                z++;
                
            }
            for(int i=0; i<r.Length; i++)
            {
                Console.Write(r[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < r.Length; i++)
            {
                for (int k = i - 1; k >= 0; k--)
                {
                    if (r[k] == r[i])
                    {

                        IsVisited = true;
                        break;
                    }
                }
                if (IsVisited == false)
                {
                    for (int j = i + 1; j < r.Length; j++)
                    {
                        if (r[i] == r[j])
                        {
                            count++;
                        }
                    }
                    if (count == 1)
                    {
                        Console.WriteLine(String.Join(",",r));
                    }

                }
            }
            


































            /* int k = 0;

             for (int i = 0; i < p.Length; i++)
             {
                 int count = 1;

                 bool IsVisited = false;
                 for (int m = i - 1; m >= 0; m--)
                 {
                     if (p[i] == r[m])
                     {
                         IsVisited = true;
                         break;
                     }
                 }
                 if (IsVisited == false)
                 {
                     r[k] = p[i];
                     k++;
                     count++;
                 }


             }



             for (int i = 0; i < q.Length; i++)
             {
                 int count = 1;

                 bool IsVisited = false;
                 for (int m = k - 1; m >= 0; m--)
                 {
                     if (q[i] == r[m])
                     {
                         IsVisited = true;
                         break;
                     }
                 }
                 if (IsVisited == false)
                 {
                     r[k] = q[i];
                     k++;
                     count++;
                 }


             }
             if(count == 1)
             {

             }


             for(int i=0;i<k;i++)
             {
                 Console.WriteLine(r[i]);
             }
 */
        }
    }
}
