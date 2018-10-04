using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TechBashCheckin.Models;
using TechBashCheckin.Storage;

namespace TechBashCheckin.Controllers
{
    public class HomeController : Controller
    {
        private CheckinViewModel _vm;

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            _vm = new CheckinViewModel {
                Locations = CheckinStorage.Instance.Locations,
                PersonLocations = CheckinStorage.Instance.PersonLocations
            };
            return View(_vm);
        }

        public bool UpdateLocation(int id, string location)
        {
            try
            {
                var personLocation = CheckinStorage.Instance.PersonLocations.FirstOrDefault(pl => pl.Person.ID == id);
                if (personLocation != null)
                {
                    personLocation.Location = location;
                    return true;
                }
            }
            catch (Exception ex) {
                return false;
            }

            return false;
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
