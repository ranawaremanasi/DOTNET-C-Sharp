using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class enumDemo
    {
        public enum Days { SUN = 1, MON, TUE, WED, THU, FRI, SAT}
        static void Main(string[] args)
        {
            //Days d;
            //d = Days.MON;
            //int monday = (int)Days.MON;
            //Console.WriteLine(monday);

            enumDemo e = new enumDemo();
            e.PrintDay(Days.MON);
            
        }

        public void PrintDay(Days d)
        {
            Console.WriteLine(d);
            Console.ReadKey();
        }
    }
}