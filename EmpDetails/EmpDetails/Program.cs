//Use class created Employee and accept and print values for 10 employees(using loops concept)
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeArray
{
    class Employee
    {
        int empid;
        string name, design;
        double salary;

        public Employee(int empid, string name, string design, double salary)
        {
            this.empid = empid;
            this.name = name;
            this.design = design;
            this.salary = salary;
        }

        public int Employeeid
        {
            get { return empid; }
            set { empid = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public String Design
        {
            get { return design; }
            set { design = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee[] emp = new Employee[10];
            int empid;
            string name, designation;
            double salary;
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter id, name, designation, salary");
                empid = Convert.ToInt32(Console.ReadLine());
                name = Console.ReadLine();
                designation = Console.ReadLine();
                salary = Convert.ToDouble(Console.ReadLine());

                emp[i] = new Employee(empid, name, designation, salary);
            }
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Details of employee no: " + i + 1);
                Console.WriteLine("Employee ID: " + emp[i].Employeeid);
                Console.WriteLine("Employee Name: " + emp[i].Name);
                Console.WriteLine("Designation: " + emp[i].Design);
                Console.WriteLine("Salary: " + emp[i].Salary);
            }
            Console.ReadKey();

        }
    }
}
