using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ListPass.Controllers
{
    public class HomeController : Controller
    {
        /*
         * ACTION TO RETURN HOMEPAGE
         */
        public IActionResult Index()
        {
            ViewData["description"] = "Our universe is amazing. It has over 100 billion galaxies. Each galaxy has over 100 billion stars. Just remarkable.";
            string[] spacecrafts = {"Whirlpool","Messier 81","Cosmos Redshift","NGC 6872","Andromeda","Milky Way","Sombrero","StarBust","Centarus A"};
            ViewData["spacecrafts"] = spacecrafts;
            return View();
        }

       

        public IActionResult Error()
        {
            return View();
        }
    }
}
