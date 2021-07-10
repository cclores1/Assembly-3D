using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Assembly_3D.Controllers
{
    public class PartsController : Controller
    {
        private IWebHostEnvironment _env;
        private string _dir;

        public PartsController(IWebHostEnvironment env)
        {
            _env = env;
            _dir = _env.ContentRootPath;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upload(IFormFile file)
        {
          

            using (var fileStream = new FileStream(Path.Combine(_dir,"file.png"), FileMode.Create, FileAccess.Write))
            {
                file.CopyTo(fileStream);
            }

                return RedirectToAction("Project");
        }
    }
}
