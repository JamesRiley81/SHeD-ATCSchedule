using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SHeDSchedule.Repository;
using SHeDSchedule.Models;

namespace SHeDSchedule.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext cntext;
        public HomeController(AppDbContext cntx)
        {
            cntext = cntx;
        }

        public IActionResult Index()
        {
            return View();
        }
        public ActionResult AddUser(string UserName, bool isATC)
        {
            try
            {
                cntext.Staff.Add(new Staff { initials = UserName, term = 1 });
                cntext.SaveChanges();
                ViewBag.Result = "Grats, ya did it!";
            }
            catch (Exception)
            {
                ViewBag.Result = ":(";
            }
            return View("Index");
        }
       

        public IActionResult Error()
        {
            return View();
        }
    }
}
