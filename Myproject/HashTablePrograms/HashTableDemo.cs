using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject.HashTablePrograms
{
    class HashTableDemo
    {
        static void Main(string[] args)
        {
            //non generic
            //Key-Value Pair
            //Keys always should be unique.

            Hashtable ht = new Hashtable();
            ht.Add("Rohit", 90);
            ht.Add("Aadarsh", 91);
            ht.Add(23,"Jayraj");
           // ht.Add(new Student(1, "priya"),"priya@gmail.com");

            Console.WriteLine(ht[23]);
            ht["Aadarsh"] = 95;

            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "=>" + d.Value);
            }
            Console.WriteLine("//////////////////////////////////////////");
            //ht.Clear();// it will clear entire hashtable.
            ht.Remove("Rohit");//it will remove the key-value pair if you specify the key in remove method.
            foreach( var k in ht.Keys)
            {
                Console.WriteLine(k + "--->" + ht[k]);
            }

            Console.WriteLine(ht.ContainsKey(896));//it will check if the key is present or not according to that it will return true or false
            Console.WriteLine(ht.ContainsValue("Jayraj"));

        }
    }


    class Hash
    {
        static void Main(string[] args)
        {
            Hashtable ht1 = new Hashtable();
            ht1.Add(new stud(1, "Rohit",85),90.4);
            ht1.Add(new stud(1, "Rohit",85),90.4);
            ht1.Add(new stud(1, "Rohit",85),90.4);
            ht1.Add(new stud(1, "Rohit",85),90.4);

            foreach(DictionaryEntry e in ht1)
            {
                Console.WriteLine(e.Key +"==>" + e.Value);
            }
        }
    }

}
