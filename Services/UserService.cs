using ECommerceProject.Data;
using ECommerceProject.Interfaces.IReponsitories;
using ECommerceProject.Interfaces.IServices;
using ECommerceProject.Models;
using ECommerceProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Services
{
    public class UserService : IUserService
    {
        private ECommerceProjectContext context;

        IUserReponsitory UserReponsitory;
        public UserService(ECommerceProjectContext context)
        {
            this.context = context;
        }


        public Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            if (context.User == null)
            {
                //return NotFound();
            }
            return UserReponsitory.GetUser();
        }

        public async Task<ActionResult<User>> GetUser(int id)
        {
            if (context.User == null)
            {
                //return NotFound();
            }
            User user = await context.User.FindAsync(id);

            if (user == null)
            {
                //return NotFound();
            }
            return await UserReponsitory.GetUser(id);
        }

        public void PutUser(int id, User user)
        {
            if (id != user.UserId)
            {
                //return BadRequest();
            }

            context.Entry(user).State = EntityState.Modified;
            try
            {
                UserReponsitory.PutUser(id, user);
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!UserExists(id))
                {
                    //return NotFound();
                }
                else
                {
                    throw;
                }
            }
            // return NoContent();
        }
        public void PostUser(User user)
        {
            if (context.User == null)
            {
                //return Problem("Entity set 'ECommerceProjectContext.User'  is null.");
            }
            UserReponsitory.PostUser(user);
            //return CreatedAtAction("GetUser", new { id = user.UserId }, user);
        }

        public ECommerceProjectContext Get_context()
        {
            return context;
        }

        public void DeleteUser(int id)
        {
            if (context.User == null)
            {
                //return NotFound();
            }
            User user = context.User.Find(id);
            if (user == null)
            {
                //return NotFound();
            }
            UserReponsitory.DeleteUser(id);
        }
        private bool UserExists(int id)
        {
            return (context.User?.Any(e => e.UserId == id)).GetValueOrDefault();
        }

        Task IUserService.DeleteUser(int id)
        {
            throw new NotImplementedException();
        }
    }
}
