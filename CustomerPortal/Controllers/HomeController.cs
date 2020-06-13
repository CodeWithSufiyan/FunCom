using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Entities.DB;
using Application.Data;

namespace CustomerPortal.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            List<ProductModel> products = new List<ProductModel>
            {
                new ProductModel
                {
                    Product_Name = "Cool Clothing with Brown Stripes",
                    Category = new ProductCategoriesModel
                    {
                        Name = "Tee"
                    },
                    Unit_Price = 200
                },
                new ProductModel
                {
                    Product_Name = "Cool Clothing with Brown Stripes",
                    Category = new ProductCategoriesModel
                    {
                        Name = "Tee"
                    },
                    Unit_Price = 200
                },
                new ProductModel
                {
                    Product_Name = "Cool Clothing with Brown Stripes",
                    Category = new ProductCategoriesModel
                    {
                        Name = "Tee"
                    },
                    Unit_Price = 200
                }
            };
            return View(products);
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
