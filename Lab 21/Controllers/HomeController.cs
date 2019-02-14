using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_21.Models;

namespace Lab_21.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
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
        public ActionResult Registration()
        {
            string[] UserDetails = { "First Name", "Last Name", "Email", "Phone Number", "Password" };
            ViewBag.UserDetails = User;
            return View();
        }
        public ActionResult Result(User u)
        {
            ViewBag.FirstName = u.FirstName;
            ViewBag.Name = $"Name: {u.FirstName} {u.LastName}";
            ViewBag.Email = $"Email: {u.Email}";
            ViewBag.Birthday = $"Birthday: {u.Birthday}";
            ViewBag.PhoneNumber = $"Phone Number: {u.Phone}";

            return View("Summary");
        }
    }
}