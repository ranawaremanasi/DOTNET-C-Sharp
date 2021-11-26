using System;
using System.Text;
using System.Collections.Generic;

namespace GenericApp
{
    public class emp
    {
        private string name;
        private int salary;

        public emp(string name, int salary)
        {
            this.name = name;
            this.salary = salary;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder(200);
            sb.AppendFormat("{0},{1}", name, salary);

            return sb.ToString();
        }

    }
    public class Program
    {
        static void Main(string[] args)
        {
            //define Dictionary collection
            Dictionary<string, emp> dObj = new Dictionary<string, emp>(2);

            //add elements to Dictionary
            emp tom = new emp("tom", 2000);
            dObj.Add("tom", tom);   // key,value
            emp john = new emp("john", 4000);
            dObj.Add("john", john);

            //print data
            foreach (Object str in dObj.Values)
            {
                Console.WriteLine(str);
            }

            Console.ReadKey();
        }
    }
}