using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using StarshipFailing.Models;

namespace StarshipFailing.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            Story Story = new Story()
            {
                RoomDescription = System.IO.File.ReadAllText(@"D:\FunProjects\StarshipFailing\StarshipFailing\StarshipFailing\Story\Description1.txt").ToString()
            };
            
            return View(Story);
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
    }
}