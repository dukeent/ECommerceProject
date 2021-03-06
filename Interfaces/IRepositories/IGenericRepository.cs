namespace ECommerceProject.Interfaces.IRepositories
{
    public interface IGenericRepository<T> where T : class
    {
        Task<IEnumerable<T>> GetAll();

        Task<T> GetById(int id);
        Task<bool> Add(T entity);
        Task<bool> Delete(int id);

        T Update(T entity);
    }
}
