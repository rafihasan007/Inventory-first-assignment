using Inventory.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventory.App.Controllers
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

        

        public ActionResult Dashboard() 
        {
            var equipments = new List<Equipment>
        {
            new Equipment { Id = 1, Name = "Mouse", Description = "Logitech", IsAssigned = true, MemberId = 1 },
            new Equipment { Id = 2, Name = "Keyboard", Description = "Zifriend", IsAssigned = true, MemberId = 3 },
            new Equipment { Id = 3, Name = "Headphone", Description = "Fantech", IsAssigned = true, MemberId = 2 },
            new Equipment { Id = 4, Name = "Mobile", Description = "Pixel", IsAssigned = true, MemberId = 2 }


        };

            var members = new List<Member>
        {
            new Member { MemberId = 1, Name = "Nabil", Email = "yasirnabil.com" },
            new Member { MemberId = 2, Name = "Rafi", Email = "rafi@gmail.com" },
            new Member { MemberId = 3, Name = "Fahim", Email = "fahim@gmail.com" }
        };


            var viewModel = new DashboardViewModel
            {
                Equipments = equipments,
                Members = members
            };
            return View(viewModel);
        }

    }
}
