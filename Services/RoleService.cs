using ECommerceProject.Interfaces.IConfiguration;
using ECommerceProject.Interfaces.IRepositories;
using ECommerceProject.Interfaces.IServices;
using ECommerceProject.Models;

namespace ECommerceProject.Services
{
    public class RoleService : IRoleService
    {
        IUnitOfWork unitOfWork;
        IRoleRepository roleRepository;

        public RoleService(IUnitOfWork _unitOfWork, IRoleRepository _roleRepository)
        {
            unitOfWork = _unitOfWork;
            roleRepository = _roleRepository;
        }
        public async Task<bool> Add(Role entity)
        {
            if (entity != null)
            {
                await unitOfWork.Roles.Add(entity);
                await unitOfWork.CompleteAsync();
                return true;
            }
            return false;
        }

        public async Task<bool> Delete(int id)
        {
            await unitOfWork.Roles.Delete(id);
            await unitOfWork.CompleteAsync();
            return true;
        }

        public async Task<IEnumerable<Role>> GetAll()
        {
            return await unitOfWork.Roles.GetAll();
        }

        public async Task<Role> GetById(int id)
        {
            return await unitOfWork.Roles.GetById(id);
        }

        public async Task<bool> Update(int id, Role entity)
        {
            unitOfWork.Roles.Update(entity);
            await unitOfWork.CompleteAsync();
            return true;
        }
    }
}
