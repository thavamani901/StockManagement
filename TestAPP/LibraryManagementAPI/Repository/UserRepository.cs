using LibraryManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Repository
{
    public class UserRepositary:IUserRepositary
    {
        private readonly ApiContext _context;

        public UserRepositary(ApiContext context)
        {
            _context = context;
        }

        public IEnumerable<Users> GetAll()
        {
            return _context.Users.Local.ToList<Users>();
        }

        public Users GetById(int UserId)
        {
            return _context.Users.Find(UserId);
        }

        public bool IsExistingUser(string Email, string Password)
        {
            return _context.Users.Where(X => X.Email == Email && X.Password == Password && X.IsActive).Any();
        }
    }
}
