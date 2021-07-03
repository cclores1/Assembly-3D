using Assembly_3D.Models;
using Assembly_3D.Services;
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
            HardCodedDataRepo hardCodedRepo = new HardCodedDataRepo();

            return View(hardCodedRepo.GetAllPart());
        }

        public IActionResult InputForm()
        {
            return View();
        }

        public IActionResult ProcessCreate(int Id)
        {

            return View("UploadNewPart");
        }
      
    }
}
