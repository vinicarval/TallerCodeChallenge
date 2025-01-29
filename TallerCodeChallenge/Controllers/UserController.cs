using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using TallerCodeChallenge.Application;

namespace TallerCodeChallenge.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {

        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = nameof(GreetValidUser))]
        public ActionResult GreetValidUser(string username)
        {
            try
            {
                UserService userService = new UserService();

                return Ok(userService.GreetValidUser(username));
            }
            catch
            {
                return BadRequest(new BadRequestObjectResult("An enexpected problem occured during the process"));
            }

        }
    }
}
