using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using StudentAPI;
using StudentAPI.Models;
using System.Data.SqlClient;

namespace StudentAPI
{
    public class BAL
    {
        DAL d = new DAL();
        public List<Student> getStudents()
        {
            SqlDataReader reader = d.getStudentData();
            List<Student> slist = new List<Student>();
            while(reader.Read())
            {
                Student obj = new Student();
                obj.rollno = Convert.ToInt32(reader["rollno"]);
                obj.name = Convert.ToString(reader["name"]);
                obj.course = reader["course"].ToString();
                slist.Add(obj);
            }
            return slist;
        }

        public Student getStudentsRollno(int rollno)
        {
            SqlDataReader reader = d.getStudentDatausingrollno(rollno);
            reader.Read();
            
                Student obj = new Student();
                obj.rollno = Convert.ToInt32(reader["rollno"]);
                obj.name = Convert.ToString(reader["name"]);
                obj.course = reader["course"].ToString();
            
            
            return obj;
        }

        public int InsertStudent(int rno,string sname,string scourse)
        {
            try
            {
                Student s = new Student() { rollno = rno, name = sname, course = scourse };
                d.InsertStudent(s);
                return 1;
            }
            catch(Exception ex)
            {
                return 0;
            }
        }

        public int UpdateStudent(int rno, string sname, string scourse)
        {
            try
            {
                Student s = new Student() { rollno = rno, name = sname, course = scourse };
                d.UpdateStudent(s);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }

        public int DeleteStudent(int rno)
        {
            try
            {
                d.DeleteStudent(rno);
                return 1;
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}