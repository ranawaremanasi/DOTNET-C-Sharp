using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.ViewModel
{
    public class EmployeeVM
    {
        public int eno { set; get; }

        public string ename { set; get; }

        public string designation { set; get; }

        public decimal salary { set; get; }
        public int deptno { set; get; }
    }
}

