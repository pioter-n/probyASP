using System;
using System.Linq;
using System.Net;
using System.Security.Claims;
using System.Security.Principal;
using Microsoft.AspNetCore.Mvc;
using WebApplication2.Domain;
using WebApplication2.Models;



namespace WebApplication2.Controllers
{
    public class UserController : Controller
    {
        private readonly AppDb _appDb;
        
        public UserController(AppDb appDb)
        {
            _appDb = appDb;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View("Login");
        }

        [HttpPost]
        public IActionResult Login(LoginViewModel viewModel)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }

            var user = _appDb.Users
                .SingleOrDefault(x => string.Equals(x.UserName, viewModel.UserName));

            if (user == null)
            {
                ModelState.AddModelError(nameof(viewModel.UserName), "User not found.");
                return View();
            }

            var isPasswordEqual =
                string.Equals(user.PasswordHash, viewModel.Password, StringComparison.InvariantCulture);
            
            if (!isPasswordEqual)
            {
                ModelState.AddModelError(nameof(viewModel.Password), "Password is incorrect.");
                return View();
            }

            User.AddIdentity(new HttpListenerBasicIdentity(user.UserName, user.PasswordHash));    
            
            return View("ToDo");
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View("Register");
        }
        
        [HttpPost]
        public IActionResult Register(RegisterViewModel viewModel)
        {
            var user = new User(viewModel.UserName, viewModel.Password);

            _appDb.Users.Add(user);
            _appDb.SaveChanges();
           
            return View("Created");
        }
    }
}