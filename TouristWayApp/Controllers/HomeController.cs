using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CoreInterfaces;
using Microsoft.Practices.Unity;

namespace TouristWayApp.Controllers
{
    public class HomeController : Controller
    {        
        IUnitOfWork uof;

        public HomeController(IUnitOfWork unit)
        {
            uof = unit;
        }

        public ActionResult Index()
        {
            
            return View(uof.Tourists.GetAll());
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