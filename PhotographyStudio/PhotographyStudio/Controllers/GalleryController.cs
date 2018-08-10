using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;
using PhotographyStudio.Models;
using Microsoft.AspNetCore.Mvc;
using PhotographyStudio.Data;

namespace PhotographyStudio.Controllers
{
    public class GalleryController : Controller
    {
        public readonly ApplicationDbContext _dbContext;

        public GalleryController(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var model = _dbContext.Galleries.ToList();
            //TODO: Install .NetCore 2.1 and include lazy loading

            //GalleryIndexViewModel model = new GalleryIndexViewModel();
            //model.SeniorsPhotos.Add("https://picsum.photos/200/300");
            //model.SeniorsPhotos.Add("https://picsum.photos/300/300");
            //model.SeniorsPhotos.Add("https://picsum.photos/250/300");
            //model.SeniorsPhotos.Add("https://picsum.photos/350/300");
            //model.SeniorsTitle = "Senior Portraits";
            return View(model);
        }

        public IActionResult Seniors()
        {
            ViewData["Message"] = "Seniors Gallery page";

            return View();
        }

        public IActionResult Family()
        {
            ViewData["Message"] = "Your Family Gallery page.";

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