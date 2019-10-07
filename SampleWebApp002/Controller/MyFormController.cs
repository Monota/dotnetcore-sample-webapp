using Microsoft.AspNetCore.Mvc;
using SampleWebApp002.Model;

namespace SampleWebApp002.Controller
{
    [ApiController]
    [Route("[controller]")]
    public class MyFormController : ControllerBase
    {
        [HttpPost]
        public ActionResult<UserApplication> Create([FromForm] UserApplication userApplication)
        {
            return new OkObjectResult(userApplication);
        }
    }
}