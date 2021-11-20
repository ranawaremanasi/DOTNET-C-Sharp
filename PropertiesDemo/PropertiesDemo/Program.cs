using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertiesinCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date();
            d.DAY = 9;
            d.MONTH = 12;
            d.Year = 2021;
            Console.WriteLine(d.DAY + "/" + d.MONTH + "/" + d.Year);


        }
    }

    class Date
    {
        int day, month, year;

        public int DAY
        {
            set
            {
                if (value >= 1 && value <= 31)
                {
                    day = value;
                }

            }
            get
            {
                return day;
            }
        }

        public int MONTH
        {
            set
            {
                if (value >= 1 && value <= 12)
                {
                    month = value;
                }

            }
            get
            {
                return month;
            }
        }

        public int Year
        {
            set
            {
                if (value > 0)
                {
                    year = value;
                }

            }
            get
            {
                return year;
            }
        }
    }
}