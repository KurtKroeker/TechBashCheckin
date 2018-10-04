using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechBashCheckin.Models;

namespace TechBashCheckin.Controllers
{
    public class HomeController : Controller
    {
        private List<string> _ecapPeople = new List<string> {
            "Kurt Kroeker",
            "Vance Hensler",
            "David Ulmer",
            "Chris Houdeshell"
        };

        public IActionResult Index()
        {
            var foo = new CheckinViewModel {
                PersonLocations = new List<PersonLocation> {
                    new PersonLocation { Person = new Person { FullName = "Kurt Kroeker" }, Location = "Other" },
                    new PersonLocation { Person = new Person { FullName = "Vance Hensler" }, Location = "Other" },
                    new PersonLocation { Person = new Person { FullName = "David Ulmer" }, Location = "Other" },
                    new PersonLocation { Person = new Person { FullName = "Chris Houdeshell" }, Location = "Other" }
                }
            };

            return View(foo);
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
