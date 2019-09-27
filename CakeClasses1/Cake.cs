using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CakeClasses
{
    public class Cake
    {
        public Traditional cakeType { get; set; }

        public Cake()
        {
        }

        public Cake(bool an, bool gr, bool we, bool ch, bool va, bool ba, bool t1, bool t2, bool t3)
        {
            cakeType = new Custom(an, gr, we, ch, va, ba, t1, t2, t3);
        }

        public Cake(int i)
        {
            cakeType = new Traditional(i);
        }

        public override String ToString()
        {
            return cakeType.ToString() + "\n";
        }
    }
}
