using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject.HashTablePrograms
{
    class ItemPurchase
    {
        public static void Main(string[] args)
        {
            //frequency of items using hash table
            ArrayList al = new ArrayList()
        {
            "Laptop",
            "Mobile",
            "Headphones",
            "Tablet",
            "Laptop",
            "Mobile",
        };
            Hashtable ht = new Hashtable();
            foreach (dynamic data in al)
            {
                if (ht.ContainsKey(data))
                {
                    int value = (int)ht[data];
                    ht[data] = value + 1;
                }
                else
                {
                    ht.Add(data, 1);
                }
            }
            foreach (DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "==>" + d.Value);
            }
        }
    }
}
