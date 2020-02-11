using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagementAPI.Model;
using LibraryManagementAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/Books")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBooksRepository booksRepository;
        public BooksController(IBooksRepository booksRepository)
        {
            this.booksRepository = booksRepository;
        }
        // GET api/values  
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Books> books = this.booksRepository.GetAll().ToList();
            return Ok(books);
        }

    }
}
