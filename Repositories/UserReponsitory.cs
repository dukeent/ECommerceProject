using ECommerceProject.Data;
using ECommerceProject.Interfaces.IReponsitories;
using ECommerceProject.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerceProject.Repositories
{
    public class UserReponsitory : IUserReponsitory
    {
        private readonly ECommerceProjectContext _context;

        public UserReponsitory(ECommerceProjectContext context)
        {
            _context = context;
        }

        public async Task<ActionResult<IEnumerable<User>>> GetUser()
        {
            return await _context.User.ToListAsync();
        }
        public async Task<ActionResult<User>> GetUser(int id)
        {
            return await _context.User.FindAsync(id);
        }

        public void PutUser(int id, User user)
        {
            _context.SaveChangesAsync();
        }

        public void PostUser(User user)
        {
            _context.User.Add(user);
            _context.SaveChangesAsync();
        }
        public void DeleteUser(int id)
        {
            _context.User.Remove(_context.User.Find(id));
            _context.SaveChangesAsync();
        }
    }
}
