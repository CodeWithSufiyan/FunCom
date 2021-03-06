using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Entities.DB;
using Application.Data;

namespace AdminPortal.Controllers
{
    public class CustomerController : Controller
    {
        // DB instance
        private readonly ApplicationDbContext  _applicationDbContext;
        private readonly ILogger<CustomerController> _logger;

        public CustomerController(
            ILogger<CustomerController> logger,
            ApplicationDbContext  applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
            _logger = logger;
        }

        //Index
        //Create
        //Edit
        //Delete
        public IActionResult Index()
        {
            List <CustomerModel> listOfProducts = _applicationDbContext.Customers.ToList();
            return View("Index", listOfProducts);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(CustomerModel m)
        {
            _applicationDbContext.Customers.Add(m);
            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Edit(long Id)
        {
            CustomerModel prdtct = _applicationDbContext.Customers.FirstOrDefault(o => o.Id == Id);
            return View(prdtct);
        }

        [HttpPost]
        public IActionResult Edit(CustomerModel m)
        {
            _applicationDbContext.Customers.Update(m);
            _applicationDbContext.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult Delete(long Id)
        {
            CustomerModel prdtct = _applicationDbContext.Customers.FirstOrDefault(o => o.Id == Id);
            return View(prdtct);
        }

        [HttpPost]
        public IActionResult Delete(CustomerModel m)
        {
            _applicationDbContext.Customers.Remove(m);
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
