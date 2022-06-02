using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ECommerceProject.Data;
using ECommerceProject.Models;
using ECommerceProject.Services;
using ECommerceProject.Interfaces.IServices;

namespace ECommerceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestUsersController : ControllerBase
    {

        private readonly IUserService UserService;

        public TestUsersController(IUserService userService)
        {
            UserService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            var res = await UserService.GetAll();
            return Ok(res);
        }

        // GET: api/TestUsers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await UserService.GetById(id);
            return Ok(user);
        }

        // PUT: api/TestUsers/5

        [HttpPut("{id}")]
        public void PutUser(int id, User user)
        {
            UserService.PutUser(id, user);
        }

        // POST: api/TestUsers
        [HttpPost]
        public void PostUser(User user)
        {
            UserService.PostUser(user);
        }

        // DELETE: api/TestUsers/5
        [HttpDelete("{id}")]
        public void DeleteUser(int id)
        {
            UserService.DeleteUser(id);
        }

    }
}
