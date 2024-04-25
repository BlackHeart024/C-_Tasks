using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Properties;
using WebAPIDemo.repository;

namespace WebAPIDemo.Controllers
{
    [Route("[controller]")]
    public class StudentController : Controller
    {
        StudentDbContext db = new StudentDbContext();
        [HttpGet("/Students/{id}")]        
        public IActionResult GetStudent(int id)
        {   var data = db.students.FirstOrDefault(x => x.Stud_Id == id);
            if(id != null)
            {
                return Ok(data);
            }
            else
            {
                return BadRequest(NotFound("Student not found"));
            }
        }
        [HttpPost("/Students")]        
        public IActionResult PostStudent(string StudName, string address, decimal phone)
        {   
            var students = new Student()
            {
                Stud_Name = StudName,
                Stud_Address = address,
                Stud_PhoneNumber = phone
            };
            db.Add(students);
            db.SaveChanges();
            return Ok(students);
        }
        [HttpPut("/Students/{id}")]        
        public IActionResult PutStudent(int id, [FromBody] Student student)
        {   
            var UpdateStudent = db.students.FirstOrDefault(x => x.Stud_Id == id);
            if(UpdateStudent != null)
            {
                UpdateStudent.Stud_Name = student.Stud_Name;
                UpdateStudent.Stud_Address = student.Stud_Address;
                UpdateStudent.Stud_PhoneNumber = student.Stud_PhoneNumber;
                db.Update(UpdateStudent);
                db.SaveChanges();
                return Ok(UpdateStudent);
            }
            else
            {
                return BadRequest(NotFound("No Data found "));
                
            }
        }
        [HttpDelete("/Students/{id}")]        
        public IActionResult DeleteStudent(int id)
        {   
            var delete= db.students.FirstOrDefault(x => x.Stud_Id == id);
            if(delete != null)
            {
                db.Remove(delete);
                db.SaveChanges();
                return Ok(delete);
            }
            else
            {
                return BadRequest(NotFound("No Data found "));
            }
        }
    }
}