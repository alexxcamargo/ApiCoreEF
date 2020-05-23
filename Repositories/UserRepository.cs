using ApiCoreEF.Data;
using ApiCoreEF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ApiCoreEF.Repositories
{
    public class UserRepository
    {

        private readonly UserContext _context;

        public UserRepository(UserContext context)
        {
            _context = context;
        }

        public IEnumerable<User> Get()
        {
            return _context.Users; 
        }

        public void Create(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
        }


        public void Update(User user)
        {
            _context.Users.Update(user);
            _context.SaveChanges();
        }

        public void Delete(User user)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }
}
