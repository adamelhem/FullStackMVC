using FullStackMvc.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace FullStackMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
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

        [HttpPost]
        public string LoigIn(string name, string password)
        {
            if (validUser(name, password))
            {
                {
                    if (!String.IsNullOrEmpty(name) && !String.IsNullOrEmpty(password))
                        return "Thank you " + name + ". Record Saved.";
                    else
                        return "Please complete the form.";
                }
            }
            else
            {
                return "wrong user name and password";
            }
        }

        private bool validUser(string name, string password)
        {
            if (name =="test"&& password == "1234")
            {
                return true;
            }

            return false;
        }
    }
}
