using Microsoft.AspNetCore.Mvc;
using System;

namespace Test.Controllers
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
