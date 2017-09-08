using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using SkiingResort.Models;

namespace SkiingResort.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var resort = new Models.SkiingResort();
            var currentWeather = new Weather();

            currentWeather.Temperature = 15;
            currentWeather.Humidity = 0.7F;
            currentWeather.Cloudiness = 1;

            resort.CurrentWeather = currentWeather;

            var newStr = "";

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Skiing Resort";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "The name of Skiing Resort.";

            return View();
        }
    }
}