using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryManagement.Models;
using LibraryManagementAPI.Model;
using LibraryManagementAPI.Repository;
using Microsoft.AspNetCore.Mvc;

namespace LibraryManagementAPI.Controllers
{
    [Route("api/Home")]
    [ApiController]
    public class HomeController : ControllerBase
    {

        private readonly ApiContext apiContext;
        private readonly IUserRepositary userRepository;

        public HomeController(ApiContext apiContext, IUserRepositary _userRepository)
        {
            this.apiContext = apiContext;
            userRepository = _userRepository;

        }
        // GET api/values  
        [HttpPost]
        public async Task<IActionResult> Login(UserViewModel User)
        {
            bool value = userRepository.IsExistingUser(User.Email, User.Password);
            return Ok(value);
        }


    }
}