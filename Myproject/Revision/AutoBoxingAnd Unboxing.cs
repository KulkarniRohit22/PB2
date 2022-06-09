using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.Revision
{
    class AutoBoxingAnd_Unboxing
    {
        static void Main(string[] args)
        {
            int a = 10;
            object ob = a;//Autoboxing converting value type to reference type automatically.
            int d = (int)ob;//unboxing converting reference type to value type explicitly.
        }
    }
}
