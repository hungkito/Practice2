﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Practice2.Models
{
    public class Employee
    {
        [Required]
        [StringLength(50)]
        public string EmployeeID { get; set; }
        [Required]
        [StringLength(50)]
        public string EmployeeName { get; set; }
        [StringLength(50)]
        public string Department { get; set; }
        [Range(0, 9999)]
        public int Salary { get; set; }
    }
}
