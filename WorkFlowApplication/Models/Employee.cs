using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkFlowApplication.Models
{
    public class Employee
    {
        [Key]
        public int Emp_ID { get; set; }
        public string EmployeeName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int Role { get; set; }

    }
}