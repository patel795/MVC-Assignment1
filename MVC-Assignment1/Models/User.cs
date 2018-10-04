using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_Assignment1.Models
{
    public class User
    {
        [Required(ErrorMessage = "Please enter your name")]
        public string UserName { get; set; }
    }
}