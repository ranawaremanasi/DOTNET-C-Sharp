//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AuthenticationDemo.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        public int eno { get; set; }
        public string ename { get; set; }
        public string designation { get; set; }
        public Nullable<decimal> salary { get; set; }
        public int deptno { get; set; }
    
        public virtual Employee Employee1 { get; set; }
        public virtual Employee Employee2 { get; set; }
    }
}
