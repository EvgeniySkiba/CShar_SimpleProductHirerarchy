using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab03
{
    public class Fiction : Book
    {
        private int timeOfAction;
        private int ageLimit;
        private string promotional;
        private string awards;
        private string series;

        public int TimeOfAction
        {
            get
            {
                return timeOfAction;
            }
            set
            {
                timeOfAction = value;
            }
        }

        public int AgeLimit
        {
            get
            {
                return ageLimit;
            }

            set
            {
                ageLimit = value;
            }
        }

        public string Promotional
        {
            get
            {
                return promotional;
            }

            set
            {
                promotional = value;
            }
        }

        public string Awards
        {
            get
            {
                return awards;
            }

            set
            {
                awards = value;
            }
        }

        public string Series
        {
            get
            {
                return series;
            }

            set
            {
                series = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()},time Of action:{timeOfAction},age limit:{ageLimit},promotional:{promotional},awards:{awards},series:{series}";
        }
    }
}