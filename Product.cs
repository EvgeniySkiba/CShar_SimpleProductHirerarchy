using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab03
{
    public class Product : IComparable
    {
        private decimal price;

        public decimal Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        private string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public override string ToString()
        {
             return string.Format("Name:{Name},price:{price}");
        }

        public int CompareTo(object obj)
        {
            Product otherDonator = (Product)obj;

            return this.Name.CompareTo(otherDonator.Name);
        }
    }
}