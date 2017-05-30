using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab03
{
    public class Book : Product
    {
        private int rating;
        private int uploadDate;
        private int publisher;
        private int language;
        private int translation;
        private int pageCount;

        public int Rating
        {
            get
            {
                return rating;
            }
            set
            {
                if (rating < 0)
                    throw new ArgumentException("incorrect rating value");
                rating = value;
            }
        }

        public int UploadDate
        {
            get
            {
                return uploadDate;
            }

            set
            {
                if(uploadDate<0)
                    throw new ArgumentNullException("incorrect date value");

                uploadDate = value;
            }
        }

        public int Publisher
        {
            get
            {
                return publisher;
            }

            set
            {
                if (publisher < 0)
                    throw new ArgumentException("incorrect publisher value");
                publisher = value;
            }
        }

        public int Language
        {
            get
            {
                return language;
            }

            set
            {
                if (publisher < 0)
                    throw new ArgumentException("incorrect language value");
                language = value;
            }
        }

        public int Translation
        {
            get
            {
                return translation;
            }

            set
            {
                if(publisher < 0)
                    throw new ArgumentException("incorrect translation value");
                translation = value;
            }
        }

        public int PageCount
        {
            get
            {
                return pageCount;
            }

            set
            {
                pageCount = value;
            }
        }
        public override string ToString()
        {
            return $"{base.ToString()},rating:{rating},upload date:{uploadDate},publisher:{publisher},language:{language},translation:{translation},page count:{pageCount}";
        }
    }
}