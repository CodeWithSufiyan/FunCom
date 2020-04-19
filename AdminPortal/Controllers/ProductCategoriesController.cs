using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using AdminPortal.Models;



namespace AdminPortal.Controllers
{
    public class ProductCategoriesController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ProductCategoriesController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Index
        //Create
        //Edit
        //Delete
        public IActionResult Index()
        {
            List <ProductCategoriesModel> listOfProducts = new List <ProductCategoriesModel> ();
            listOfProducts.Add(new ProductCategoriesModel{
                Id = 1,
                Name = "Mens Kurti"

            });

            listOfProducts.Add(new ProductCategoriesModel{
                Id = 2,
                Name = "Mens Casual"
                
            });

            listOfProducts.Add(new ProductCategoriesModel{
                Id = 3,
                Name = "Womens Casual"
                
            });

            listOfProducts.Add(new ProductCategoriesModel{
                Id = 4,
                Name = "Womens Salvaar"
                
            });

            return View(listOfProducts);
        }

        public IActionResult Create()
        {
            return View();
        }

        public IActionResult Edit()
        {
            return View();
        }

        public IActionResult Delete()
        {
            return View();
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
