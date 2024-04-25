using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Properties;

namespace WebAPIDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : Controller
    {
        [HttpGet("/emp")]
        public IActionResult GetEmployee([FromBody] List<Employee> employee)
        {
            return Ok(employee);
        }
        [HttpPost("/PostEmp/{id}")]
        public IActionResult PostEmployee(int id, [FromBody] List<Employee> employee)
        {
            return Ok(employee);
        }
        [HttpPost("/PostEmp1/{id}")]
        public string PostEmployee1(int id, [FromBody] List<Employee> employee)
        {
            return $"{id}";
        }
    }
}