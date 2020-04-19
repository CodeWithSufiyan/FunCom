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
    public class CustomerController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public CustomerController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Index
        //Create
        //Edit
        //Delete
        public IActionResult Index()
        {
            List <CustomerModel> listOfProducts = new List <CustomerModel> ();
            listOfProducts.Add(new CustomerModel{
                ProductCategory = "Amazon Device Accessories",
                Conditions_Allowed = "New, Certified refurbished, Used",
                Approval_Required ="No"

            });

            listOfProducts.Add(new CustomerModel{
                ProductCategory = "Baby Products (excluding apparel)",
                Conditions_Allowed = "New",
                Approval_Required ="No, but certain sub-categories require approval."

            });

            listOfProducts.Add(new CustomerModel{
                ProductCategory = "Beauty",
                Conditions_Allowed = "New",
                Approval_Required ="No"

            });


            listOfProducts.Add(new CustomerModel{
                ProductCategory = "Cell Phones & Accessories",
                Conditions_Allowed = "New, Used, Certified refurbished; Unlocked",
                Approval_Required ="No"

            });

            listOfProducts.Add(new CustomerModel{
                ProductCategory = "Office Products",
                Conditions_Allowed = "New, Certified refurbished, Used, Collectible",
                Approval_Required ="No, but certain sub-categories require approval."

            });

            listOfProducts.Add(new CustomerModel{
                ProductCategory = "Pet Supplies",
                Conditions_Allowed = "New, Certified refurbished, Used",
                Approval_Required ="No, but certain sub-categories require approval."

            });

            listOfProducts.Add(new CustomerModel{
                ProductCategory = "Toys & Games",
                Conditions_Allowed = "New, Collectible",
                Approval_Required ="No, but certain sub-categories require approval. Approval may be required to sell during the winter holiday season."

            });

            listOfProducts.Add(new CustomerModel{
                ProductCategory = "Watches",
                Conditions_Allowed = "New",
                Approval_Required ="Yes"

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
