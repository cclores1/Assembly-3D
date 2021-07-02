using Assembly_3D.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assembly_3D.Controllers
{
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            List<PartsModel> partList = new List<PartsModel>();

            partList.Add(new PartsModel { Id = 1, Name = "Duck", Description = "Duck" });
            partList.Add(new PartsModel { Id = 1, Name = "Dog", Description = "Dog" });

            return View(partList);
        }

      
    }
}
