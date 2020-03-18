using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BoneGameOrder.DAL;
using BoneGameOrder.Models;

namespace BoneGameOrder.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Upload()
        {
            return View();
        }
        public ActionResult SeeAvailable()
        {
            BoneGameEntities boneGameDB = new BoneGameEntities();
            ViewBag.Orders = (from a in boneGameDB.GameOrders
                              where a.StartDate.Year == DateTime.Today.Year &&
                              a.StartDate.Month == DateTime.Today.Month &&
                              a.StartDate.Day == DateTime.Today.Day
                              select a).ToList();
            return View();
        }
        public ActionResult Order()
        {
            BoneGameEntities boneGameDB = new BoneGameEntities();
            ViewBag.Orders = (from a in boneGameDB.GameOrders
                              where a.StartDate.Year == DateTime.Today.Year &&
                              a.StartDate.Month == DateTime.Today.Month &&
                              a.StartDate.Day == DateTime.Today.Day
                              select a).ToList();
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
    }
}