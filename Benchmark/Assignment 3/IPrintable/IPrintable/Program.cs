/*
 Create interface with name IPrintable and print method. implement interface in Account and employee class. Verify in main class and check working.
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample
{
    interface IPrintable
    {
        void Print();
    }
    class Account : IPrintable
    {
        public void PrintData()
        {
            Console.WriteLine("Account Class");
        }
        public void Print()
        {
            Console.WriteLine("Permanent Account");
        }
    }
    class Employee : IPrintable
    {
        public void PrintData()
        {
            Console.WriteLine("Employee Class");
        }
        public void Print()
        {
            Console.WriteLine("Employee Account");
        }
    }
    class Program
    {
        public void Call_Print(IPrintable p)
        {
            p.Print();
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            Account p2 = new Account();
            Employee p3 = new Employee();

            p2.PrintData();
            p.Call_Print(p2);
            p3.PrintData();
            p.Call_Print(p3);

            Console.ReadKey();
        }
    }
}