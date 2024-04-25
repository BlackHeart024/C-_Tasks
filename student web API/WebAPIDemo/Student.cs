namespace WebAPIDemo.Properties
{
    public class Student
    {
        public int Stud_Id { get; set; }
        public string? Stud_Name { get; set; }
        public string? Stud_Address { get; set; }
        
        // [RegularExpression(@"^[0-9]{10}$")]
        public decimal Stud_PhoneNumber { get; set; }
    }
}