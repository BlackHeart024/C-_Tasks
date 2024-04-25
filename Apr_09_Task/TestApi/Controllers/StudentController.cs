using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers;

[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase
{
    [HttpGet("/student/{Stud_Id}")]
    public IActionResult GetStudent([FromBody] Student students)
    {
        return Ok(students);
    }
    [HttpPost("/student")]
    public IActionResult PostStudent([FromBody] Student students)
    {
        return Ok(students);
    }
}