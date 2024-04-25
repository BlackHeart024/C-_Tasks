using System.ComponentModel.DataAnnotations;

namespace Company
{
    public class Employee
    {
        [Key]
        public int Emp_id { get; set; }
        public int Emp_department_id { get; set; }
        public string? Emp_name { get; set; }
        public string? Emp_address { get; set; }
        public decimal Emp_salary { get; set; }
        public Department? Department { get; set; }
    }
}