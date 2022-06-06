using ECommerceProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly IUserService userService;
        public RegisterController(IUserService userService)
        {
            this.userService = userService;
        }
        [HttpPost("Register")]
        [AllowAnonymous]
        public IActionResult Register(User user)
        {
            userService.PostUser(user);
            return Ok("Register Succesfully");
        }

    }
}
