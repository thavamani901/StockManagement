using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using LibraryManagement.Models;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagement.Controllers
{
    public class AccountController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(UserViewModel User)
        {
            var details = new UserViewModel();
            if (!string.IsNullOrEmpty(User.Email) && !string.IsNullOrEmpty(User.Password))
            {

                return RedirectToAction("GetBooks", "Book");
                //using (var client = new HttpClient())
                //{
                //    client.BaseAddress = new Uri("https://localhost:44317/api/Home");

                //    var postTask = client.PostAsJsonAsync<UserViewModel>("User", User);
                //    postTask.Wait();


                //    var result = postTask.Result;
                //    if (result.IsSuccessStatusCode)
                //    {
                //        return RedirectToAction("GetBooks", "Book");
            }
            else //web api sent error response 
            {
                //log response status here..
                ModelState.AddModelError(string.Empty, "Server error. Please contact administrator.");
            }

            return View(User);
        }



    }
}
