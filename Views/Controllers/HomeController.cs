using Microsoft.AspNetCore.Mvc;
using System;

namespace Views.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("MyView", new string[] {"Apple", "Orange", "Pear" });
        }

        public ViewResult List() => View();
        public ViewResult List2() => View();
    }
}