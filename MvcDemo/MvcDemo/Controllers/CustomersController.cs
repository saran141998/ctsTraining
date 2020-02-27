using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class CustomersController : Controller
    {
        public ActionResult Details()
        {
            Customers c = new Customers
            {
                CustomerId = 1,
                CustomerName="Rohtih",
                CustomerCity="Markapur",
                CustomerEmail="rb@gmail.com"
            };
            return View(c);
        }
    }
}