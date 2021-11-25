using System;

namespace InheritanceDemo
{
    class Employee
    {
        int id;
        string name;
        string designation;

        public Employee(int id, string name, string deignation)
        {
            this.id = id;
            this.name = name;
            this.designation = deignation;
        }
        public void PrintData()
        {
            Console.WriteLine(id + " " + name + " " + designation + " ");
        }

        class PermanantEmp : Employee
        {
            double basic_sal;
            public PermanantEmp(int id, string name, string designation, double basic_sal) : base(id, name, designation)
            {
                this.basic_sal = basic_sal;
            }
            public void PrintData()
            {
                base.PrintData();
                Console.WriteLine(basic_sal);
            }

            public void calculatesal(double basic_sal)
            {
                double hra = 0.5 * basic_sal;
                double da = 0.3 * basic_sal;
                double gross_sal = basic_sal + hra + da;
                Console.WriteLine("gross salary of permanent employee is :" + gross_sal);
            }
        }
        class WagedEmp : Employee
        {
            int no_of_hrs;
            int hrs_amt;

            public WagedEmp(int id, string name, string designation, double salary) : base(id, name, designation)
            {
                this.no_of_hrs = no_of_hrs;
                this.hrs_amt = hrs_amt;
            }
            public void PrintData()
            {
                base.PrintData();
                Console.WriteLine(no_of_hrs + " " + hrs_amt);
            }

            public void calculatesal(int no_of_hrs, int hrs_amt)
            {
                int salary = no_of_hrs * hrs_amt;
                Console.WriteLine("salary of Waged employee is :" + salary);
            }

        }

        class Program
        {
            static void Main(string[] args)
            {
                PermanantEmp p = new PermanantEmp(1, "Manasi", "Manager", 200000);
                WagedEmp w = new WagedEmp(11, "sam", "HR", 50000);
                Console.WriteLine("Permanent Employee");
                p.PrintData();
                
                Console.WriteLine("Waged Employee");
                w.PrintData();

                Console.ReadKey();
            }
        }
    }
}