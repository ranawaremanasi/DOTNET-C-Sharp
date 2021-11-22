using System;
 
namespace Demo
{
    public class Program
    {
        static void Main(string [] args)
        {
            Employee e1 = new Employee();
            e1.PrintData();

            Employee e2= new Employee("Manasi","ABC");
            e2.PrintData();
            Console.ReadKey();
        }
    }

    class Employee
    {
        static int srno;
        int empno;
        string name, designation;

        public Employee()
        {
            empno = ++srno;
            name = "Asha";
            designation = "Manager";
        }

        public Employee (string name,string designation)
        {
            this.empno = ++srno;
            this.name = name;
            this.designation = designation; 
        }
        public void PrintData()
        {
            Console.WriteLine("Employee no =" + empno + "Name =" + name + "Designation =" + designation);
        }
    }
}