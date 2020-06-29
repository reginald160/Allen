using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Allen.Controllers
{
    public class FAQsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
