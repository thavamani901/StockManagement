using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class BookController : Controller
    {
        public IActionResult GetBooks()
        {
            IList<BookViewModel> Books = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://localhost:44317/api/");
                var responseTask = client.GetAsync("Books");
                responseTask.Wait();

                var result = responseTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readTask = result.Content.ReadAsAsync<IList<BookViewModel>>();
                    readTask.Wait();

                    Books = readTask.Result;
                }
                else //web api sent error response 
                {
                    //log response status here..

                    Books = null;

                    ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
                }
            }
            return View(Books);
        }

        //public IActionResult AddNewBook()
        //{
        //    BookViewModel bookModel = new BookViewModel();
        //    return View(bookModel);
        //}

        [HttpGet]
        public IActionResult AddNewBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewBook(BookViewModel bookModel)
        {
            return RedirectToAction("GetBooks");
            //return View();
        }

    }
}