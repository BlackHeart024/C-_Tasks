using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Entity_Framework
{
    
    public class DepartmentModel
    {
        [Key]
        public int Dept_Id {get; set;}
        public string? Dept_Name {get; set;}

        public List<EmployeeModel>? Employees {get;set;}
    }
}