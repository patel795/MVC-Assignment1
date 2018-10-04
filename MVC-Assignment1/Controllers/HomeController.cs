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
        //This function opens the main page
        public ViewResult Index(string name)
        {
            ViewBag.Name = name;
            return View();//It returns the html format of the index page 
        }

        //This function helps to open the second page and also fill the details using the url
        [HttpGet]
        public ViewResult UserForm(string username)
        {
            User user = new User();//Creating object of class User
            user.UserName = username;
            return View(user);//It returns the html format of the user page
        }

        //It gets the data entered by the user and if everything is fine, then it goes to the third page.
        [HttpPost]
        public ViewResult UserForm(User user)
        {
            if (ModelState.IsValid)
            {
                return View("FinalPage", user);//It navigates to the third page.
            }
            else
            {
                return View();//It returns the second page again if the details are not in correct format
            }
        }

        //This function is for the last page.
        [HttpGet]
        public ViewResult LastPage(string name)
        {
            User user = new User();
            user.UserName = name;
            return View("FinalPage", user);//Retruns the html format of the last page
        }

        //This function is used to print out all the details entered by the user on the last page
        [HttpGet]
        public ViewResult AllDetails(string name, string number, string email)
        {
            User user = new User();
            user.UserName = name;
            user.PhoneNumber = number;
            user.EmailId = email;
            return View("FinalPage", user);//Returns the html format of the last page with all the details printed.
        }
    }
}