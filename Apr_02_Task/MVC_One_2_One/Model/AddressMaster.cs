using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

namespace Company
{
    public class AddressMaster
    {
        [Key]
        public int Address_id { get; set; }
        public string? Address { get; set; }
        public EmployeeMaster? EmployeeMaster { get; set; }
    }
}