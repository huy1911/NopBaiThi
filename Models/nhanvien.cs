using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace BaiThi.Models
{
    public class nhanvien
    {
        [Key]
        [Required(ErrorMessage = "EmployeeID is required")]
        [StringLength(1)]
        public string EmployeeID { get; set; }
        public string Employeename { get; set; }
        public string Department { get; set; }
        public int Salary { get; set; }
        
    }
}