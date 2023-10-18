using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment7Library
{
    public class SmartPhone : IComparable
    {
        public SmartPhone()
        {

        }
        public SmartPhone(int Imeino, string name, string model, double price)
        {
            IMEINo = Imeino;
            Name = name;
            Model = model;
            Price = price;

        }

        public int IMEINo { get; set; }
        public string Name { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }


        public int CompareTo(object obj)
        {
            if (obj == null) return 1;
            SmartPhone nextSmartPhone = obj as SmartPhone;
            if (nextSmartPhone != null)
            {
                return this.Price.CompareTo(nextSmartPhone.Price);
                
            }
            else
            {
                throw new ArgumentException("Object doesn't have a proper price");
            }
        }

    }
}
