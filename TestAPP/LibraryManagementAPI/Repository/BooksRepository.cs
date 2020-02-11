using LibraryManagementAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryManagementAPI.Repository
{
    public class BooksRepository:IBooksRepository
    {
        private readonly ApiContext _context;
     
        public BooksRepository(ApiContext context)
        {
            _context = context;
        }

        public IEnumerable<Books> GetAll()
        {
            return _context.Books.Local.ToList<Books>();
        }

        public Books GetById(int BookId)
        {
            return _context.Books.Find(BookId);
        }

        public void Insert(Books book)
        {
            _context.Books.Add(book);
        }
        public void Update(Books book)
        {
            
        }
        public void Delete(int EmployeeID)
        {
           
        }
        public void Save()
        {
            
        }
      
    }
}
