using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Controllers
{
    public class CalcController : Controller
    {
        // GET: /<controller>

        public IActionResult plusTen(int number) {

            if (number!= 0) {
                ViewData["number"] = number;
                ViewData["result"] = number + 10;
            }
            return View();
        }
    }
}
