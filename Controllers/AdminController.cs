using ECommerceProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class AdminController : ControllerBase
    {
        private readonly IUserService UserService;
        private readonly IAdminProductService AdminProductService;

        public AdminController(IUserService userService, IAdminProductService adminProductService)
        {
            UserService = userService;
            AdminProductService = adminProductService;
        }

        [HttpGet]
        [Authorize]
        [Route("Get All User")]
        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            var res = await UserService.GetAll();
            return Ok(res);
        }


        [HttpGet("{user_id}")]
        //[Route("Get User by ID")]
        public async Task<ActionResult<User>> GetUser(int id)
        {
            var user = await UserService.GetById(id);
            return Ok(user);
        }



        [HttpPut("{user_id}")]
        //[Route("Update User's information")]
        public void PutUser(int id, User user)
        {
            UserService.PutUser(id, user);
        }


        [HttpPost]
        [Route("Create new User")]
        public void PostUser(User user)
        {
            UserService.PostUser(user);
        }


        [HttpDelete("{id}")]
        //[Route("Delete User by ID")]
        public void DeleteUser(int id)
        {
            UserService.DeleteUser(id);
        }


        [HttpGet]
        [Route("Get all Product")]
        public async Task<ActionResult<IEnumerable<Product>>> GetProduct()
        {
            var res = await AdminProductService.GetAll();
            if(res == null){
                return NoContent();
            }
            return Ok(res);
        }


        [HttpGet("{product_id}")]
        //[Route("Get Product by ID")]
        public async Task<ActionResult<Product>> GetProduct(int id)
        {
            var product = await AdminProductService.GetById(id);
            return Ok(product);
        }



        [HttpPut("{product_id}")]
        //[Route("Update Product's information")]
        public void PutProduct(int id, Product product)
        {
            AdminProductService.PutProduct(id, product);
        }


        [HttpPost]
        [Route("Add new Product")]
        public void PostProduct(Product product)
        {
            AdminProductService.PostProduct(product);
        }


        [HttpDelete("{product_id}")]
        //[Route("Delete Product by ID")]
        public void DeleteProduct(int id)
        {
            AdminProductService.DeleteProduct(id);
        }
    }
}
