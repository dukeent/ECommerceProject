using ECommerceProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace ECommerceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class LoginController : ControllerBase
    {
        private readonly IAuthenticationService authenticationService;
        private readonly IUserService userService;
        public LoginController(IAuthenticationService authenticationService, IUserService userService)
        {
            this.authenticationService = authenticationService;
            this.userService = userService;
        }

        
        [HttpPost("Login")]
        [AllowAnonymous]
        public IActionResult Authenticate(String username, String password)
        {
            var user = GetUser(username, password);
            if (user == null)
            {
                return BadRequest();
            }
            else
            {

                var token = authenticationService.Authenticate(user.Result.Username, user.Result.RoleID);
                if(token == null)
                {
                    return Unauthorized();
                }
                else
                {
                    return Ok(user.Result.FirstName + " "+ user.Result.LastName + " " + user.Result.RoleID
                        + "\n" + token);
                }
            }
        }

        [HttpGet("Get User")]
        [Authorize (Roles = "1")]
        public async Task<User> GetUser(String username, String password)
        {
            return await userService.GetUserByUsernameAndPassword(username, password);
        }
        
    }
}
