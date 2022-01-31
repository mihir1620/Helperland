using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperLand.Controllers
{
    public class CreateUser : Controller
    {
        public IActionResult Create()
        {
            return View();
        }
    }
}
