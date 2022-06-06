using ECommerceProject.Models;

namespace ECommerceProject.Interfaces.IReponsitories
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
        Task<bool> PostUser(User user);
        Task<bool> DeleteUser(int id);
        Task<bool>  PutUser(int id, User user);
        Task<User> GetUserByUsernameAndPassword(string username, string password);
    }
}
