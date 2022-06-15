using ECommerceProject.Data;
using ECommerceProject.Interfaces.IRepositories;
using ECommerceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ECommerceProjectContext _dbContext) : base(_dbContext)
        {
        }
        Task<IEnumerable<User>> IUserRepository.GetAll()
        {
            return base.GetAll();
        }
        Task<User> IUserRepository.GetById(int id)
        {
             return base.GetById(id);
        }

        Task<bool> IUserRepository.PostUser(User user)
        {
            return base.Add(user);
        }

        Task<bool> IUserRepository.DeleteUser(int id)
        {
            return base.Delete(id);
        }

        Task<bool> IUserRepository.PutUser(int id, User user)
        {
            return base.UpdateByID(id, user);
        }
        async Task<User> IUserRepository.GetUserByUsernameAndPassword(string username, string password)
        {
            var user = await base.dbContext.User.FirstOrDefaultAsync<User>(x => x.Username == username && x.Password == password);
            if (user == null)
            {
                return null;
            }
            return user;
        }
        
    }
}
