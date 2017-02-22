using MVCTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCTest.Controllers
{
    public class HomeController : Controller
    {
       
        public ActionResult Index()
        {
            var model = from p in _people
                        orderby p.City
                        select p;

            return View(model);
        }

        public ActionResult AjaxPost()
        {
            var model = from p in _people
                        orderby p.City
                        select p;
            return PartialView(model);
        }

        static List<Person> _people = new List<Person>
        {
            new Person
            {
                Id = 1,
                Name = "Wassim",
                Cellphone = "073591 0453",
                City = "Stockholm",
                Country="Sweden"
            },
            new Person
            {
                Id = 2,
                Name = "Andre",
                Cellphone = "072591 0453",
                City = "Paris",
                Country="France"
            },
            new Person
            {
                Id = 3,
                Name = "Stev",
                Cellphone = "071591 0453",
                City = "London",
                Country="England"
            },
            new Person
            {
                Id = 4,
                Name = "Mike",
                Cellphone = "070591 0453",
                City = "Ottawa",
                Country="Canada"
            },
            new Person
            {
                Id = 5,
                Name = "Ulf",
                Cellphone = "074591 0453",
                City = "D.C",
                Country="USA"
            },
            new Person
            {
                Id = 6,
                Name = "Sokoban",
                Cellphone = "078591 0453",
                City = "Tokyo",
                Country="Japan"
            },new Person
            {
                Id = 7,
                Name = "Jörgan",
                Cellphone = "079591 0453",
                City = "Oslo",
                Country="Norway"
            },
        };
    }
}