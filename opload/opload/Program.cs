using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    class Student
    {
        int marks;
        public Student(int m)
        {
            marks = m;
        }
        public static Student operator + (Student a,Student b)
        {
            Student result = new Student(0);
            result.marks = a.marks + b.marks;
            return result;
        }

        public static Student operator -(Student a, Student b)
        {
            Student result = new Student(0);
            result.marks = a.marks - b.marks;
            return result;
        }

        public static Student operator *(Student a, Student b)
        {
            Student result = new Student(0);
            result.marks = a.marks * b.marks;
            return result;
        }

        public static Student operator /(Student a, Student b)
        {
            Student result = new Student(0);
            result.marks = a.marks / b.marks;
            return result;
        }

        public static bool operator ==(Student a, Student b)
        {
            bool status = false;
            if (a.marks== b.marks)
            {

                status = true;
                Console.WriteLine("Marks are Equal");
            }
            return status;
        }
        public static bool operator !=(Student a, Student b)
        {
            bool status = false;

            if (a.marks != b.marks)
            {

                status = true;
                Console.WriteLine("Marks are not equal");
            }
            return status;
        }
        public void PrintMarks()
        {
            Console.WriteLine(marks);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student ob1 = new Student(77);
            Student ob2 = new Student(78);

            Student add=ob1+ ob2;
            add.PrintMarks();

            Student sub = ob1 - ob2;
            sub.PrintMarks();

            Student mul = ob1 * ob2;
            mul.PrintMarks();

            Student div = ob1 / ob2;
            div.PrintMarks();

            if (ob1 == ob2)
                Console.WriteLine("Marks are equal ");
            else
                Console.WriteLine("Marks are not equal ");


            Console.ReadKey();
        }
    }
}