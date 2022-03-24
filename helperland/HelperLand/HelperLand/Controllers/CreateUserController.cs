using HelperLand.Data;
using HelperLand.Models;
using HelperLand.ViewModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace HelperLand.Controllers
{
   
    public class CreateUserController : Controller
    {

        HelperLandContext db = new HelperLandContext();

        private readonly HelperLandContext _helperlandContext = null;

        public CreateUserController(HelperLandContext helperlandContext)
        {
            _helperlandContext = helperlandContext;

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserViewModel model)
        {
           

                var isPhone = isMobileExist(model.Mobile);
                var isEmail = isEmailExist(model.Email);
                if(isEmail)
                {
                    ModelState.AddModelError("EmailExist", "Email already exist");
                    return View();
                }

                if (isPhone)
                {
                    ModelState.AddModelError("MobileExist", "Mobile number already exist");
                    return View();
                }
                User newUser = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Mobile = model.Mobile,
                    Password = Hash.HashPass(model.Password),
                    //Password = Crypto.SHA256(model.Password),
                    //var verified = Crypto.VerifyHashedPassword(hash, "foo");
                    CreatedDate = DateTime.Now,
                    ModifiedDate = DateTime.Now,
                    IsRegisteredUser = false,
                    WorksWithPets = false,
                    IsActive = false,
                    IsApproved = false,
                    IsDeleted = false,
                    ModifiedBy = 2,
                    UserTypeId = 1
            };

                TempData["Message"] = "Registered Successfully";
                _helperlandContext.Add(newUser);
                _helperlandContext.SaveChanges();
                return RedirectToAction("Create");

            
            return View();
        }

        [NonAction]
        public bool isEmailExist(string email)
        {
            var e = db.Users.Where(e => e.Email == email).FirstOrDefault();
            return e != null;
        }

        [NonAction]
        public bool isMobileExist(string mobile)
        {
            var e = db.Users.Where(e => e.Mobile == mobile).FirstOrDefault();
            return e != null;
        }
    }
}
