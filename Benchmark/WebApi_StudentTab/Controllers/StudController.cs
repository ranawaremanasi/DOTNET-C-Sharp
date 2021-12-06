using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using StudentAPI.Models;

namespace StudentAPI.Controllers
{
    public class StudController : ApiController
    {
        BAL b = new BAL();
        [HttpGet]
        public List<Student> GetStudentList()
        {
            List<Student> slist = b.getStudents();
            return slist;
        }

        [HttpGet]
        public Student GetStudentListRollno(int rno)
        {
            Student slist = b.getStudentsRollno(rno);
            return slist;
        }

        [HttpPost]
        public int InsertDept(Student s)
        {
            int res = b.InsertStudent(s.rollno, s.name, s.course);
            return res;
        }

        [HttpPut]
        public int UpdateDept(Student s)
        {
            int res = b.UpdateStudent(s.rollno, s.name, s.course);
            return res;
        }

        [HttpDelete]
        public int DeleteDept(Student s)
        {
            int res = b.DeleteStudent(s.rollno);
            return res;
        }
    }
}

