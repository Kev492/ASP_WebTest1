﻿using AspWebTest2.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AspWebTest2.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CustomerController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetCustomerDetails(string customerId)
        {
            var customer = _context.CUSTOMER
                .FirstOrDefault(c => c.CustomerID == customerId);

            return View("~/Views/Home/Index.cshtml", customer);
        }
    }
}
