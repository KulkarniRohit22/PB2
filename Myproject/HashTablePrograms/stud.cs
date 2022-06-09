using System;
using System.Collections.Generic;
using System.Text;

namespace Myproject.HashTablePrograms
{
    class stud
    {
        int sid;
        string name;
        double percent;

        public stud(int sid, string name, double percent)
        {
            this.sid = sid;
            this.name = name;
            this.percent = percent;
        }

        public override bool Equals(object obj)
        {
            return obj is stud stud &&
                   sid == stud.sid &&
                   name == stud.name &&
                   percent == stud.percent;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(sid, name, percent);
        }
    }
}
