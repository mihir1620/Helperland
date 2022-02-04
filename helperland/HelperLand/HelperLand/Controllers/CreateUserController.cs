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
        //private readonly UserManager<IdentityUser> userManager;
        //private readonly SignInManager<IdentityUser> signInManager;
        private readonly HelperLandContext _helperlandContext = null;

        public CreateUserController(HelperLandContext helperlandContext)
        {
            _helperlandContext = helperlandContext;
            //this.userManager = userManager;
            //this.signInManager = signInManager;

        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(UserViewModel model)
        {
            if (ModelState.IsValid)
            {
                User newUser = new User
                {
                    FirstName = model.FirstName,
                    LastName = model.LastName,
                    Email = model.Email,
                    Mobile = model.Mobile,
                    Password = model.Password,
                    //Password = Crypto.HashPassword(model.Password),
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

                //var result = await userManager.CreateAsync(newUser, model.Password);

                //if (result.Succeeded)
                //{
                //    await signInManager.SignInAsync(newUser, isPersistent: false);
                //    return RedirectToAction("Index", "Home");
                //}

                //foreach (var error in result.Errors)
                //{
                //    ModelState.AddModelError(string.Empty, error.Description);
                //}


                _helperlandContext.Add(newUser);
                _helperlandContext.SaveChanges();
                return RedirectToAction("Create");
                //_helperlandContext.Users.Add(model);
                //_helperlandContext.SaveChanges();
                //return RedirectToAction("Create");

            }
            return View();
        }

       
    }
}
