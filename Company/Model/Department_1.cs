using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace Company
{
    public class Department
    {
        [Key]
        public int Dept_id { get; set; }
        public string? Dept_name { get; set; }
        public List<Employee>? Employee { get; set; }
    }
}