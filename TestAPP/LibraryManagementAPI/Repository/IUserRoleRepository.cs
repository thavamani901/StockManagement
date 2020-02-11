using LibraryManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Repository
{
    public interface IUserRoleRepository
    {
        IEnumerable<UserRoles> GetAll();
        UserRoles GetById(int UserRoleId);
        int GetRoleByRoleIdAndUserId(int UserId,int RoleId);
    }
}
