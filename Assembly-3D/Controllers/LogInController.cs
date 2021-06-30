using Assembly_3D.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assembly_3D.Controllers
{
    public class LogInController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ProcessLogIn(UserModel userModel)
        {
            if (userModel.Username == "Carlo" && userModel.Password == "Clores")
            {
                return View("LogInSuccess", userModel);
            }
            else
            { 
                return View("LogInFailure", userModel);
            }
                
        }
        

        public IActionResult LogIn(UserModel userModel)
        {
            return View();
        }
    }
}
