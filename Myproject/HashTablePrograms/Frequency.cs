using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject.HashTablePrograms
{
    class Frequency
    {
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add("sun");
            al.Add("mon");
            al.Add("tue");
            al.Add("sun");
            al.Add("tue");
            al.Add("fri");
            al.Add("sun");
            al.Add("sat");


            Hashtable ht = new Hashtable();
            foreach(dynamic data in al)
            {
                if(ht.ContainsKey(data))//sun
                {
                    int value = (int) ht[data];
                    ht[data] = value + 1;
                }
                else
                {
                    ht.Add(data, 1);
                }
            }
            foreach(DictionaryEntry d in ht)
            {
                Console.WriteLine(d.Key + "==>" + d.Value);
            }
        }
    }
}
