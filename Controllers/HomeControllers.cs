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

      [HttpGet("/new")]
      public ActionResult CreateForm()
      {
        return View();
      }
      [HttpPost("/display")]
      public ActionResult CreateContact()
      {
        Contact newContact = new Contact(
        Request.Form["name"],
        Convert.ToInt32(Request.Form["phone"]),
        Convert.ToInt32(Request.Form["address"])
        );
        return View("Form",newContact);
      }
    }
  }
