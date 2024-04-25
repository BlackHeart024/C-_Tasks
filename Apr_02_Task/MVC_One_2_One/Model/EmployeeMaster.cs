using System.ComponentModel.DataAnnotations;

namespace Company
{
    public class EmployeeMaster
    {
        [Key]
        public int Employee_id { get; set; }
        public int Employee_address_id { get; set; }
        public string? Employee_name { get; set; }
        public AddressMaster? AddressMaster { get; set; }
    }
}