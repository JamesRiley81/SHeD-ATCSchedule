using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SHeDSchedule.Repository;
using SHeDSchedule.Models;
using SHeDSchedule.Models.ViewModels;
namespace SHeDSchedule.Controllers
{
    public class HomeController : Controller
    {
        private IStaffRepository staff;
        public HomeController(IStaffRepository st)
        {
            staff = st;
        }

        public IActionResult Index()
        {    
            return View(new StaffViewModel() { staff = staff.Students(), monday = null });
        }
        public ActionResult AddUser(string UserName, bool isATC)
        {
            try
            {
                Staff s = new Staff() { initials = UserName, ATC = isATC, term = 1 };
                staff.CreateStaff(s);
                ViewBag.Result = "Grats, ya did it!";
            }
            catch (Exception)
            {
                ViewBag.Result = ":(";
            }
            return View("Index", new StaffViewModel() { staff = staff.Students(), monday = null });
        }
       [HttpGet]
       public ActionResult Removeuser(int staffid)
        {          
            try
            {
                Staff s = staff.Student(staffid);
                staff.DeleteStaff(s);
                ViewBag.Result = "Grats, ya did it!";
            }
            catch (Exception)
            {
                ViewBag.Result = ":(";
            }
            return View("Index", new StaffViewModel() { staff = staff.Students(), monday = null });

        }

        public IActionResult Error()
        {
            return View();
        }
        public ActionResult GetStudentSchedule(int studentID)
        {
            var s = staff.Student(studentID);
            return View("Index", new StaffViewModel() { staff = staff.Students(), monday = staff.MondaySchedule(s), tuesday = staff.TuesdaySchedule(s), wednesday = staff.WednesdaySchedule(s), thursday = staff.ThursdaySchedule(s), friday = staff.FridaySchedule(s) });
        }
    }
}
