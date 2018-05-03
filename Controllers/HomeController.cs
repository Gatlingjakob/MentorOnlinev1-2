using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MentorOnlinev1.Models;
using MentorOnlinev1.Models.Entities;


namespace MentorOnlinev1.Controllers
{
    public class HomeController : Controller
    {
 
        MentorDbContext db = new MentorDbContext();

        public IActionResult Index()
        {
            return View();
        }

         public IActionResult Test()
        {      
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        // Create
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Mentor ment)
        {
            db.Mentors.Add(ment);
            db.SaveChanges();
            return View();
        }
        
    }
}
