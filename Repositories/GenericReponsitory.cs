using ECommerceProject.Interfaces.IReponsitories;

namespace ECommerceProject.Repositories
{
    public class GenericReponsitory<T> : IGenericReponsitory<T> where T : class
    {
        public Task<bool> Add(T entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<T>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
