using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CustomerPortal.Models;

namespace CustomerPortal.Controllers
{
    public class ProductController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public ProductController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            {
            List <ProductModel> listOfProducts = new List <ProductModel> ();
            listOfProducts.Add(new ProductModel{
                Product_Name ="Top",
                Brand_Name="Biba",
                Package_qty=1,
                Size="small",
                Colour="red",
                Department="Womens"

            });
            listOfProducts.Add(new ProductModel{
                Product_Name ="Shirt",
                Brand_Name="Polo",
                Package_qty=2,
                Size="extra small",
                Colour="blue",
                Department="Mens"

            });
            listOfProducts.Add(new ProductModel{
                Product_Name ="Tsirt",
                Brand_Name="Lp",
                Package_qty=5,
                Size="Large",
                Colour="White",
                Department="Mens"

            });
            listOfProducts.Add(new ProductModel{
                Product_Name ="Shirt",
                Brand_Name="Gucci",
                Package_qty=5,
                Size="Extra Large",
                Colour="Chex Yellow",
                Department="Mens"

            });
            listOfProducts.Add(new ProductModel{
                Product_Name ="Shirt",
                Brand_Name="Tommy Hilfiger",
                Package_qty=2,
                Size="Large",
                Colour="red",
                Department="Mens"

            });
            return View(listOfProducts);
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
