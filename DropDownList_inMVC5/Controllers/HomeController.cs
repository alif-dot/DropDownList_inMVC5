using DropDownList_inMVC5.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownList_inMVC5.Controllers
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

        public ActionResult Test()
        {           
            var countries = new List<Country>()
            {
                new Country(){ Id=1, Text = "Bangladesh"},
                new Country(){ Id=1, Text = "Japan"},
                new Country(){ Id=1, Text = "China"},
                new Country(){ Id=1, Text = "Indonesia"},
                new Country(){ Id=1, Text = "Turkey"},
                new Country(){ Id=1, Text = "Afganistan"},
                new Country(){ Id=1, Text = "Pakistan"},
                new Country(){ Id=1, Text = "Saudi Arabia"}
            };

            ViewBag.list = countries;

            //Employee emp = new Employee()
            //{
            //    Country = "Bangladesh"
            //};

            return View();
        }

        [HttpPost]
        public ActionResult Test(Employee emp)
        {
            if(ModelState.IsValid)
            {
                return RedirectToAction("Test");
            }

            var countries = new List<Country>()
            {
                new Country(){ Id=1, Text = "Bangladesh"},
                new Country(){ Id=1, Text = "Japan"},
                new Country(){ Id=1, Text = "China"},
                new Country(){ Id=1, Text = "Indonesia"},
                new Country(){ Id=1, Text = "Turkey"},
                new Country(){ Id=1, Text = "Afganistan"},
                new Country(){ Id=1, Text = "Pakistan"},
                new Country(){ Id=1, Text = "Saudi Arabia"}
            };

            ViewBag.list = countries;

            return View();
        }
    }

    class Country
    {
        public int Id { get; set; }
        public string Text { get; set; }
    }
}