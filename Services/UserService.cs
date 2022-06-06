using ECommerceProject.Data;
using ECommerceProject.Interfaces.IConfiguration;
using ECommerceProject.Interfaces.IReponsitories;
using ECommerceProject.Interfaces.IServices;
using ECommerceProject.Models;
using ECommerceProject.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork unitOfWork;
        IUserRepository userRepository;
        
        public UserService(IUnitOfWork _unitOfWork, IUserRepository _userRepository)
        {
            unitOfWork = _unitOfWork;
            userRepository = _userRepository;
        }

        public async Task<bool> DeleteUser(int id)
        {
            await unitOfWork.Users.DeleteUser(id);
            await unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await unitOfWork.Users.GetAll();
        }

        public Task<User> GetById(int id)
        {
            return unitOfWork.Users.GetById(id);
        }

        public async Task<bool> PostUser(User user)
        {
            if (user != null)
            {
                await unitOfWork.Users.PostUser(user);
                await unitOfWork.CompleteAsync();
                return true;
            }
            return false;
        }

        public Task<bool> PutUser(int id, User user)
        {
            throw new NotImplementedException();
        }
        public async Task<User> GetUserByUsernameAndPassword(string username, string password)
        {
            return await unitOfWork.Users.GetUserByUsernameAndPassword(username, password);
        }

    }
}
