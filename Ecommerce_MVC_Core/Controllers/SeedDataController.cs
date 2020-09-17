using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PROG7311_TASK2.Controllers
{
    public class SeedDataController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}