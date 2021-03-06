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
    public class ProductController : Controller
    {
        // DB instance
        private readonly ApplicationDbContext  _applicationDbContext;
        private readonly ILogger<ProductController> _logger;

        public ProductController(
            ILogger<ProductController> logger,
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
            // To avoid throwing error . Try something & catch error block
            try{
                // ModelState is state of ProductModel m
                if(!ModelState.IsValid){
                    var errorList = ModelState.ToDictionary(
                        kvp => kvp.Key,
                        kvp => kvp.Value.Errors.Select(o => o.ErrorMessage).ToArray()
                    );
                    ViewBag.Errors = errorList;
                    List<ProductCategoriesModel> dbProdCatg = _applicationDbContext.ProductCategories.ToList();
                              
                    ViewBag.uiProdCatgList = dbProdCatg; 
                    return View();
                }
                _applicationDbContext.Products.Add(m);
                _applicationDbContext.SaveChanges();

                return RedirectToAction("Index");
            }
            catch(Exception ex){
                ViewBag.ExceptionErrorMessage = ex.InnerException.Message;
                List<ProductCategoriesModel> dbProdCatg = _applicationDbContext.ProductCategories.ToList();
                            
                ViewBag.uiProdCatgList = dbProdCatg; 
                return View();
            }
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
