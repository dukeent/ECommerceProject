using ECommerceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Interfaces.IServices
{
    public interface IUserService
    {
        public Task<IEnumerable<User>> GetAll();
        public Task<User> GetById(int id);
        public Task<bool> PostUser(User user);
        public Task<bool> DeleteUser(int id);
        public Task<bool> PutUser(int id, User user);
        public Task<User> GetUserByUsernameAndPassword(string username, string password);
    }
}
