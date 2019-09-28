using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Controllers
{
    public class CalculatorController : Controller
    {
        // GET: /<controller>/
        public IActionResult PlusTen(int number)
        {
            ViewData["number"] = number;
            ViewData["result"] = number + 10;
            return View();
        }
    }
}
