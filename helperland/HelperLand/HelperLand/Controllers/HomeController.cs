using HelperLand.Data;
using HelperLand.Models;
using HelperLand.ViewModels;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace HelperLand.Controllers
{
    
    public class HomeController : Controller
    {

        private readonly HelperLandContext _helperlandContext = null;
        public IHostingEnvironment hostingEnvironment { get; }
        //private readonly ILogger<HomeController> _logger;

        public HomeController(HelperLandContext helperlandContext,
                    IHostingEnvironment hostingEnvironment)
        {
            _helperlandContext = helperlandContext;
            this.hostingEnvironment = hostingEnvironment;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {

            HttpContext.Session.Remove("username");
            return RedirectToAction("Index", "Home");

        }

        public IActionResult FAQ()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Price()
        {
            return View();
        }

        public IActionResult Contact(bool IsSuccess = false)
        {
            ViewBag.issuccess = IsSuccess;
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.File != null)
                {
                    string uploadFolder = Path.Combine(hostingEnvironment.WebRootPath, "Files");
                    uniqueFileName = Guid.NewGuid().ToString() + "_" + model.File.FileName;
                    string filePath = Path.Combine(uploadFolder, uniqueFileName);
                    model.File.CopyTo(new FileStream(filePath, FileMode.Create));
                }
                ContactU newContact = new ContactU
                {
                    Name = @model.Name + @model.LastName,
                    Email = model.Email,
                    Subject = model.Subject,
                    Message = model.Message,
                    PhoneNumber = model.PhoneNumber,
                    CreatedOn = DateTime.Now,
                    FileName = uniqueFileName
                };
                _helperlandContext.Add(newContact);
                //_helperlandContext.ContactUs.Add(contactus);
                _helperlandContext.SaveChanges();
                return RedirectToAction("Contact", new { issuccess = true });
            }
            return View();
        }

        public IActionResult BecomeHelper()
        {
            return View();
        }

        [HttpPost]
        public IActionResult BecomeHelper(UserViewModel model)
        {
            //if (ModelState.IsValid)
            //{
                User newHelper = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Mobile = model.Mobile,
                    Password = Hash.HashPass(model.Password),
                    //var verified = Crypto.VerifyHashedPassword(hash, "foo");
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsRegisteredUser = false,
                    WorksWithPets = false,
                    IsActive = false,
                    IsApproved = false,
                    IsDeleted = false,
                    ModifiedBy = 2,
                    UserTypeId = 2

                };
                _helperlandContext.Add(newHelper);
                _helperlandContext.SaveChanges();
                return RedirectToAction("BecomeHelper");
                //_helperlandContext.Users.Add(model);
                //_helperlandContext.SaveChanges();
                //return RedirectToAction("Create");

           // }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
