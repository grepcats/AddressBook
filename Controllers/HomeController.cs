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
            Request.Form["phone-number"]
          );

          Address newAddress = new Address(
          Request.Form["street"],
          Request.Form["city-state"],
          Request.Form["zip"]
          );
          newContact.SetAddress(newAddress);
          //Console.WriteLine("name is " + newContact.GetName() + "and street is " + newContact.GetAddress().GetStreet());
          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
        }

        [HttpPost("/delete")]
        public ActionResult DeleteAll()
        {
          Contact.ClearAll();
          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
        }



        [HttpGet("/{id}")]
        public ActionResult Details(int id)
        {
          Contact detailContact = Contact.Find(id);
          //Console.WriteLine("name is " + detailContact.GetName() + " and ID is " + detailContact.GetId() + " and passed id is " + id);
          return View(detailContact);
        }

        [HttpPost("/contacts/delete/{id}")]
        public ActionResult DeleteOne(int id)
        {
          Contact.Delete(id);
          List<Contact> allContacts = Contact.GetAll();
          return View("Index", allContacts);
        }

        [HttpGet("/contacts/update/{id}")]
        public ActionResult CreateUpdate(int id)
        {
          Contact updateContact = Contact.Find(id);
          return View(updateContact);
        }

        [HttpPost("/update/{id}")]
        public ActionResult UpdateOne(int id)
        {
          Contact updateContact = Contact.Find(id);
          updateContact.SetName(Request.Form["name"]);
          updateContact.SetPhone(Request.Form["phone-number"]);
          updateContact.GetAddress().SetStreet(Request.Form["street"]);
          updateContact.GetAddress().SetCityState(Request.Form["city-state"]);
          updateContact.GetAddress().SetZip(Request.Form["zip"]);
          // List<Contact> allContacts = Contact.GetAll();

          return View("Details", updateContact);
        }
    }
}
