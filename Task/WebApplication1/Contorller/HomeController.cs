using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Contorller
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public string Yapram()
        {
            return  "tamam yaprak";
        }

    }
}
