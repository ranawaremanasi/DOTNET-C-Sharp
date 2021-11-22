//Write a program in C# to accept list of employees and print list of employees.(using generic collection)

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace GenericDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Generic HashSet ");
            HashSet<Employee> employees = new HashSet<Employee> {
                {
                    new Employee {
                        Emp_Id = 101, Emp_name = "John", Dept_name = "HR"
                    }
                },
                {
                    new Employee {
                        Emp_Id = 102, Emp_name = "Smith", Dept_name = "IT"
                    }
                },
                {
                    new Employee {
                        Emp_Id = 103, Emp_name = "Robert", Dept_name = "Accounts"
                    }
                },
                {
                    new Employee {
                        Emp_Id = 104, Emp_name = "Scott", Dept_name = "IT"
                    }
                }
            };
            Console.WriteLine("{0,-6}{1,10}{2,-8}", "Emp_Id", "Emp_name", "Dept_name");

            foreach (var employee in employees)
            {
                Console.WriteLine("{0,-8}{1,-10}{2,5}", employee.Emp_Id, employee.Emp_name, employee.Dept_name);
            }

            Console.ReadKey();
        }
    }
    public class Employee
    {
        public int Emp_Id
        {
            get;
            set;
        }
        public string Emp_name
        {
            get;
            set;
        }
        public string Dept_name
        {
            get;
            set;
        }
    }
}