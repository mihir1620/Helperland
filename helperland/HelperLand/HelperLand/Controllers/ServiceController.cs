using HelperLand.Data;
using HelperLand.Models;
using HelperLand.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperLand.Controllers
{
    
    public class ServiceController : Controller
    {
        HelperLandContext db = new HelperLandContext();
        User user = new User();
        public IActionResult Service()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Check()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Check(Zipcode model)
        {
            Zipcode zip = db.Zipcodes.Where(z => z.ZipcodeValue == model.ZipcodeValue).FirstOrDefault();

            /*ServiceRequest serviceRequest = new ServiceRequest
            {
                ZipCode = model.ZipcodeValue,
                ServiceStartDate = DateTime.Now,

            };
            db.Add(serviceRequest);
            db.SaveChanges();*/

            if (zip != null)
            {
                ViewBag.zipmsg = "Service Provider is available in your area";
                return PartialView("Schedule");
            }
            else
            {
                ViewBag.zipmsg2 = "We are not providing service in this area. We will notify you if any helper would start working near your area";
            }
            return View("Service");
        }

        [HttpGet]
        public IActionResult Schedule()
        {
            return View("Service");
        }

    }
}
