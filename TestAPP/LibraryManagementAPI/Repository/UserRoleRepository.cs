using LibraryManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Repository
{
    public class UserRoleRepository: IUserRoleRepository
    {

        private readonly ApiContext _context;

        public UserRoleRepository(ApiContext context)
        {
            _context = context;
        }

        public IEnumerable<UserRoles> GetAll()
        {
            return _context.UserRoles.Local.ToList<UserRoles>();
        }

        public int GetRoleByRoleIdAndUserId(int RoleId, int UserId)
        {
            return _context.UserRoles.Find(RoleId, UserId).RoleId;
        }

        public UserRoles GetById(int UserId)
        {
            return _context.UserRoles.Find(UserId);
        }
    }
}
