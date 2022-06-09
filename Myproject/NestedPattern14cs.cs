using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject
{
    class NestedPattern14cs
    {
        static void Main(string[] args)
        {

            /*for (int i = 1;i<= 6;i++)
            {
                for (int j = i; j <= 3; j++)
                {
                   
                    Console.Write(j);
                }
                Console.WriteLine();
            }*/

            
            char q = 'Z';
            Console.WriteLine("Enter The Number : ");
            int p = int.Parse(Console.ReadLine());
            for (int i = p; i>=0; i--)
            {

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(q--);
                }
                Console.WriteLine();
            }



            /*int i, j ;
            Console.WriteLine("Enter the alphabet");
            int n =Convert.ToInt32(Console.ReadLine());

            for( i=1; i<=n; i++)
            {
                for( j =1; j<=i; j++)
                {
                    Console.Write((char)(j + 64));
                    
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine();*/


            /*int i, j;
            char k = 'A';
            for (i = 1; i <= 5; i++)
            {
                for (j = 1; j <= i; j++)
                    Console.Write(k++ + " ");
                Console.WriteLine();
            }*/
        }
    }
}
