using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab03
{
    public class Magazine : Product
    {
        private string edition;
        private string region;

        public string Edition
        {
            get
            {
                return edition;
            }

            set
            {
                edition = value;
            }
        }

        public string Region
        {
            get
            {
                return region;
            }

            set
            {
                region = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()},edition:{edition},region:{region}";
        }
    }
}
