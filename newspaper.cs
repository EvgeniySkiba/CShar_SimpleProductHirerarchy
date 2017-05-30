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
                if (released < 0)
                    throw new ArgumentException("incorrect released value");
                released = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()},released:{released}";
        }
    }
}
