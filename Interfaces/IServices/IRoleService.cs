using ECommerceProject.Models;

namespace ECommerceProject.Interfaces.IServices
{
    public interface IRoleService
    {
        Task<IEnumerable<Role>> GetAll();

        Task<Role> GetById(int id);
        Task<bool> Add(Role entity);
        Task<bool> Delete(int id);
        Task<bool> Update(int id, Role entity);
    }
}
