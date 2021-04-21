using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mock_Assessment_5a.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Mock_Assessment_5a.Controllers
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

        public IActionResult Calculator()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Result(int num1, int num2, Operations operation)
        {

            ViewData["Num1"] = num1;
            ViewData["Num2"] = num2;

            if (operation == Operations.Plus)
            {
                ViewData["Result"] = num1 + num2;
                ViewData["Operation"] = "+";
            }
            else if (operation == Operations.Minus)
            {
                ViewData["Result"] = num1 - num2;
                ViewData["Operation"] = "-";
            }
            else if (operation == Operations.Multiply)
            {

                ViewData["Result"] = num1 * num2;
                ViewData["Operation"] = "x";
            }
            else
            {
                ViewData["Result"] = num1 / num2;
                ViewData["Operation"] = "/";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
