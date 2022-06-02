using ECommerceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Interfaces.IServices
{
    public interface IUserService
    {
        Task<ActionResult<IEnumerable<User>>> GetUser();
        Task<ActionResult<User>> GetUser(int id);
        void PutUser(int id, User user);
        void PostUser(User user);
        Task DeleteUser(int id);

    }
}
