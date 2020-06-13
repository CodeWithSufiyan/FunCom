using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Entities.DB;
using Application.Data;
using Microsoft.AspNetCore.Mvc.Rendering;//TAG

namespace AdminPortal.Controllers
{
    public class SocialMediaController : Controller
    {
        // DB instance
        private readonly ApplicationDbContext  _applicationDbContext;
        private readonly ILogger<SocialMediaController> _logger;

        public SocialMediaController(
            ILogger<SocialMediaController> logger,
            ApplicationDbContext  applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        //Index
        //Create
        //Edit
        //Delete
        [HttpGet]
        public IActionResult Index()
        {
            List <SocialMediaModel> listOfProducts = _applicationDbContext.SocialMedia.ToList();
            return View("Index", listOfProducts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(SocialMediaModel m)
        {
            _applicationDbContext.SocialMedia.Add(m);
            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(long Id)
        {
            SocialMediaModel prdtct = _applicationDbContext.SocialMedia.FirstOrDefault(o => o.Id == Id);
            return View(prdtct);
        }

        [HttpPost]
        public IActionResult Edit(SocialMediaModel m)
        {
            _applicationDbContext.SocialMedia.Update(m);
            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(long Id)
        {
            SocialMediaModel prdtct = _applicationDbContext.SocialMedia.FirstOrDefault(o => o.Id == Id);
            return View(prdtct);
        }

        [HttpPost]
        public IActionResult Delete(SocialMediaModel m)
        {
            _applicationDbContext.SocialMedia.Remove(m);
            _applicationDbContext.SaveChanges();
            
            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
