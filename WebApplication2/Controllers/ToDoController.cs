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
    public class ToDoController : Controller
    {
        private readonly AppDb _appDb;
        
        public ToDoController(AppDb appDb)
        {
            _appDb = appDb;
        }

        [HttpPost]
        public IActionResult TodoList(ToDoViewModel viewModel)
        {
            var todo = new User(viewModel.Description);
            _appDb.Users
         
        }

    }
}