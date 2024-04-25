using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework
{
    
    public class EmployeeModel
    {
        [Key]
        public int Emp_Id {get; set;}
        public int DeptId { get; set; }
        public string? First_Name {get; set;}
        public string? Last_Name {get; set;}
        public string? City {get; set;}
        public string? State {get; set;}

        public DepartmentModel? department {get;set;}

    }
}