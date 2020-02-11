using LibraryManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Repository
{
    public interface IBooksRepository
    {
        IEnumerable<Books> GetAll();
        Books GetById(int BookId);
        void Insert(Books Books);
        void Update(Books Books);
        void Delete(int BookId);
        void Save();
    }
}
