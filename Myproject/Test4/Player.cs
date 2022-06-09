using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Myproject.Test4
{
    class Player
    {
        int playerid;
        string name, country, team;
        static void Main(string[] args)
        {
            ArrayList al = new ArrayList();
            al.Add(1);
            al.Add("MSDhoni");
            al.Add("India");
            al.Add("Chennai Super Kings");

            foreach (var i in al)
            {
                Console.Write(" " + i);
            }

        }
    }
}
