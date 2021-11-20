//Create a class Employee with data members empno, ename, designation and salary. Write public methods to accept and print values of all the data members. Call and verify class functionality using main method.

using System;

namespace Demo
{
    class EmpDetails
    {
        public int Empid;
        public string Name;
        public string Dept;
        public string Salary;

        
        EmpDetails()  //constuctor for initialization
        {
            Empid = 101;
            Name = "John";
            Dept = "HR";
            Salary = "35000";
        }
        public void displayData()
        {
            Console.WriteLine("Employee ID=" + Empid);
            Console.WriteLine("Name=" + Name);
            Console.WriteLine("Department=" + Dept);
            Console.WriteLine("Salary=" +Salary);
        }
        static void Main(string[] args)
        {
            
            EmpDetails obj = new EmpDetails();
            obj.displayData();

            Console.WriteLine(obj.Empid);
            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Dept);
            Console.WriteLine(obj.Salary);
        }
    }
}



/*
using System;

namespace Demo
{
    class EmpDetails
    {
        public static void Main(string[] args)
        {
            string eno;
            string ename;
            string dept;
            Console.WriteLine("Enter employee no:");
            eno = Console.ReadLine();
            Console.Write("Enter name:");
            ename = Console.ReadLine();
            Console.WriteLine("Enter Department:");
            dept = Console.ReadLine();
            Console.WriteLine("Employee Details : " + eno + ename + dept);
        }
    }
}
*/