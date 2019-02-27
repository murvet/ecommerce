using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebSiteExample.Models;
using WebSiteExample.DAL;
using System.Web.Helpers;
using System.IO;

namespace WebSiteExample.Controllers
{
    //test
    public class HomeController : Controller
    {
        WebsiteDB db = new WebsiteDB();

        public ActionResult Index()
        {
            return View(db.Products.ToList());
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Contact([Bind(Include = "Id,Name,Email,Phone,Subject,Message")] Contact contact) 
        {
            if (ModelState.IsValid)
            {
                db.Contacts.Add(contact);
                db.SaveChanges();
                ModelState.AddModelError("", "Mesajınız Başarılı bir şekilde iletilmiştir");
                //return RedirectToAction("Contact", "Home");

            }
            return View(contact);
        }
    }
}