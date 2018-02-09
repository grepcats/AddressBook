using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
//using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
