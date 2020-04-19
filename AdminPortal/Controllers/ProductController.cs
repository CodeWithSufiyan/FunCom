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
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ProductController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Index
        //Create
        //Edit
        //Delete
        public IActionResult Index()
        {
            List <ProductModel> listOfProducts = new List <ProductModel> ();
            listOfProducts.Add(new ProductModel{
                Id = 1,
                ProductCategoryFk = 1,
                Name = "Men_Kurti_1"

            });

            listOfProducts.Add(new ProductModel{
                Id = 2,
                ProductCategoryFk = 1,
                Name = "Men_Kurti_2"

            });


            listOfProducts.Add(new ProductModel{
                Id = 3,
                ProductCategoryFk = 1,
                Name = "Men_Kurti_3"

            });


            listOfProducts.Add(new ProductModel{
                Id = 4,
                ProductCategoryFk = 2,
                Name = "Women_Casual_1"

            });

            listOfProducts.Add(new ProductModel{
                Id = 5,
                ProductCategoryFk = 4,
                Name = "Women_Salvaar_1"

            });

            listOfProducts.Add(new ProductModel{
                Id = 6,
                ProductCategoryFk = 3,
                Name = "Women_Casual_1"

            });

            listOfProducts.Add(new ProductModel{
                Id = 7,
                ProductCategoryFk = 2,
                Name = "Men_Casual_2"

            });

            listOfProducts.Add(new ProductModel{
                Id = 8,
                ProductCategoryFk = 2,
                Name = "Men_Casual_2"

            });

            listOfProducts.Add(new ProductModel{
                Id = 9,
                ProductCategoryFk = 2,
                Name = "Men_Casual_2"

            });

            listOfProducts.Add(new ProductModel{
                Id = 10,
                ProductCategoryFk = 3,
                Name = "Women_Casual_2"

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
