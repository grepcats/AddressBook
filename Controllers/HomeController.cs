using System.Collections.Generic;
using System;
using Microsoft.AspNetCore.Mvc;
using AddressBook.Models;

namespace AddressBook.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public ActionResult Index()
        {
            List<Contact> allContacts = Contact.GetAll();
            return View(allContacts);
        }

        [HttpGet("/contacts/new")]
        public ActionResult CreateForm()
        {
          return View();
        }

        [HttpPost("/new")]
        public ActionResult Create()
        {
          Contact newContact = new Contact(
            Request.Form["name"],
            Request.Form["phone-number"],
            Request.Form["address"]
          );
          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
        }
    }
}
