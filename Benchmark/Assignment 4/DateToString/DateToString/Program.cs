using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverideFunction
{
    public class Date
    {
        public int hrs { get; set; }
        public int mins { get; set; }
        public int secs { get; set; }

        public override string ToString()
        {
            return this.hrs + ": " + this.mins + " :" + this.secs;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Date d = new Date() { hrs= 1, mins = 46, secs = 32 };

            Console.WriteLine(d.ToString());
            Console.ReadLine();
        }
    }
}







