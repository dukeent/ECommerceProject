using ECommerceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Interfaces.IReponsitories
{
    public interface IUserReponsitory
    {
        Task<ActionResult<IEnumerable<User>>> GetUser();
        Task<ActionResult<User>> GetUser(int id);
        void PutUser(int id, User user);
        void PostUser(User user);
        void DeleteUser(int id);

    }
}
