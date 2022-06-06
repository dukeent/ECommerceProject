using ECommerceProject.Interfaces.IReponsitories;
using ECommerceProject.Models;


namespace ECommerceProject.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
<<<<<<<<< Temporary merge branch 1
=========

>>>>>>>>> Temporary merge branch 2
        protected ECommerceProjectContext dbContext;
        protected DbSet<T> dbSet;
        public GenericRepository(ECommerceProjectContext _dbContext)
        {
            dbContext = _dbContext;
            dbSet = dbContext.Set<T>();
        }
        public async Task<bool> Add(T entity)
        {
            if (entity != null)
            {
                await dbSet.AddAsync(entity);
                return true;
            }
            return false;
        }

<<<<<<<<< Temporary merge branch 1
=========

>>>>>>>>> Temporary merge branch 2
        public async Task<bool> Delete(int id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                dbSet.Remove(entity);
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<T>> GetAll()
        {
              return await dbSet.ToListAsync();

        }

        public async Task<T> GetById(int id)
        {
            var entity = await dbSet.FindAsync(id);
            if (entity != null)
            {
                return entity;
            }
            else
            {
                return null;
            }
        }
    }
<<<<<<<<< Temporary merge branch 1
}
=========
}
>>>>>>>>> Temporary merge branch 2
