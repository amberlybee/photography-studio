using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using PhotographyStudio.Models;
using Microsoft.AspNetCore.Mvc;

namespace PhotographyStudio.Controllers
{
    public class GalleryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Seniors()
        {
            ViewData["Message"] = "Seniors Gallery page";

            return View();
        }

        public IActionResult Family()
        {
            ViewData["Message"] = "Your Family Galler page.";

            return View();
        }
        public IActionResult Children()
        {
            ViewData["Message"] = "Your Children Gallery page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
}
}