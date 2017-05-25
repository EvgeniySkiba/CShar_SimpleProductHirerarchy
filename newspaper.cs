using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab03
{
    public class newspaper
    {
    }

    public class Newspaper : Product
    {
        private int released;

        public int Released
        {
            get
            {
                return released;
            }

            set
            {
                released = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()},released:{released}";
        }
    }
}
