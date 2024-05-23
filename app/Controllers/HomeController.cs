using Microsoft.AspNetCore.Mvc;

namespace BeanstalkApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Congratulations, you have successfully deployed a beanstalk application with Terraform and GitHub Actions");
        }
    }
}
