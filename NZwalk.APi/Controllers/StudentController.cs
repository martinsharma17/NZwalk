using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace NZwalk.APi.Controllers
{
    //https:localhost:portno/api/student

    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAllStudent()
        {
            string[] studentnames = new string[] { "a" ,"b","c","d","e","f"};
            return Ok(studentnames);
        }
    }
}
