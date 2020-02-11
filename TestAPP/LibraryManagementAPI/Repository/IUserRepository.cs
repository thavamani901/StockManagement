using LibraryManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Repository
{
    public interface IUserRepositary
    {
        IEnumerable<Users> GetAll();
        Users GetById(int UserId);
        bool IsExistingUser(string Email, string Password);
    }
}
