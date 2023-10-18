using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7Library
{
    public class IComparerClass:IComparer<SmartPhone>
    {
        public int IMEINo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }

            public int Compare(SmartPhone x, SmartPhone y)
            {
                SmartPhone  sp1= x as SmartPhone;
                SmartPhone sp2  = y as SmartPhone;
                return sp1.Name.CompareTo(sp2.Name);
            }
    }
}

