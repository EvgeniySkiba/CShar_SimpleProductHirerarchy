using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab03
{
    public class Technical : Book
    {
        private string heading;

        public string Heading
        {
            get
            {
                return heading;
            }

            set
            {
                heading = value;
            }
        }
             public override string ToString()
        {
            return $"{base.ToString()},heading:{heading}";
        }
    }
}
