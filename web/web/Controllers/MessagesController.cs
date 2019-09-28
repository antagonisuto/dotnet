using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace web.Controllers
{
    public class MessagesController : Controller
    {
        // GET: /<controller>/
        public IActionResult ShowMessage (string messages)
        {

            if (string.IsNullOrEmpty(messages))
            {
                ViewData["Message"] = "Message are empty";
            }
            else
            {
                ViewData["Message"] = messages;
            }

            return View();
        }
    }
}
