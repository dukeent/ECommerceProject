using ECommerceProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationService authenticationService;
        public LoginController(IAuthenticationService authenticationService)
        {
            this.authenticationService = authenticationService;
        }

        private static User user = new User();
        [HttpPost("Login")]
        public IActionResult Authenticate(User user)
        {
            if (user == null)
            {
                return BadRequest();
            }
            else
            {
                var token = authenticationService.Authenticate(user.Username, user.Password);
                if(token == null)
                {
                    return Unauthorized();
                }
                else
                {
                    return Ok(token);
                }
            }
        }


    }
}
