using MVC_Assignment1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC_Assignment1.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }

        [HttpGet]
        public ViewResult UserForm(string username)
        {
            User user = new User();
            user.UserName = username;
            return View(user);
        }

        [HttpPost]
        public ViewResult UserForm(User user)
        {
            if (ModelState.IsValid)
            {
                // TODO: Email response to the party organizer
                return View("FinalPage", user);
            }
            else
            {
                // there is a validation error
                return View();
            }
        }
    }
}