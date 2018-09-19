using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using team_dictionary.Models;

namespace team_dictionary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Search()
        {
            Dictionary<string, string> dictionary = new Dictionary<string, string>();
            dictionary.Add("Supplier", "Поставщик");
            dictionary.Add("Поставщик", "Supplier");
            
            

            return View();
        }
    }
}
