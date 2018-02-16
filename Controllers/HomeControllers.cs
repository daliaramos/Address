using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Contacts.Models;

namespace Contacts.Controllers
  {
    public class HomeController : Controller
    {
      [HttpGet("/")]
      public ActionResult Index()
      {
        List<Contact> allContacts = Contact.GetAll();
        return View(allContacts);
      }

      [HttpGet("/newContact/new")]
      public ActionResult newContact()
      {
        return View();
      }
      [HttpPost("/newContact")]
      public ActionResult CreateContact()
      {
        Contact newContact = new Contact(
        Request.Form["name"],
        Convert.ToInt32(Request.Form["phone"]),
        Request.Form["street"],
        Convert.ToInt32(Request.Form["zip"])

        );
        return View("Form",newContact);
      }
      [HttpPost("/clear")]
        public ActionResult ItemListClear()
        {
          Contact.ClearAll();
          List<Contact> allContacts = new List<Contact> {};
          return View("index", allContacts);
        }
    }
  }
