using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminPortal.Models;
using AdminPortal.Data;
using Microsoft.AspNetCore.Mvc.Rendering;//TAG

namespace AdminPortal.Controllers
    {
    public class ProductController : Controller
    {
        // DB instance
        private readonly ApplicationDbContext  _applicationDbContext;
        private readonly ILogger<HomeController> _logger;

        public ProductController(
            ILogger<HomeController> logger,
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
            List <ProductModel> listOfProducts = _applicationDbContext.Products.ToList();
            return View("Index", listOfProducts);
        }

        [HttpGet]
        public IActionResult Create()
        {            
            //TAG
            // PULLING CATEGORIES FROM DATABASE
            List<ProductCategoriesModel> dbProdCatg = _applicationDbContext.ProductCategories.ToList();
            // NOW SOMETHING STRANGE. WE WILL CREATE A CACHE OBJECT AND ASSIGN OUR CATEGORIES
            // TO IT. IN THE VIEW SIDE, WE WILL RENDER IT                            
            ViewBag.uiProdCatgList = dbProdCatg; // VIEWBAG IS A TEMP MEMORY. U CAN CALL IT IN UI DIRECTLY

            return View();
        }

        [HttpPost]
        public IActionResult Create(ProductModel m)
        {
            _applicationDbContext.Products.Add(m);
            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(long Id)
        {
            ProductModel prdtct = _applicationDbContext.Products.FirstOrDefault(o => o.Id == Id);
            return View(prdtct);
        }

        [HttpPost]
        public IActionResult Edit(ProductModel m)
        {
            _applicationDbContext.Products.Update(m);
            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(long Id)
        {
            ProductModel prdtct = _applicationDbContext.Products.FirstOrDefault(o => o.Id == Id);
            return View(prdtct);
        }

        [HttpPost]
        public IActionResult Delete(ProductModel m)
        {
            _applicationDbContext.Products.Remove(m);
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
