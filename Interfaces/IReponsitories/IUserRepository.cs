using ECommerceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Interfaces.IReponsitories
{
    public interface IUserRepository
    {
        public Task<IEnumerable<User>> GetAll();
        public Task<User> GetById(int id);
        public Task<bool> PostUser(User user);
        public Task<bool> DeleteUser(int id);
        public Task<bool>  PutUser(int id, User user);

    }
}
