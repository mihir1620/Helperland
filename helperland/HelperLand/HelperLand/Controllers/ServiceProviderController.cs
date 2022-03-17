using HelperLand.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HelperLand.Models;
using HelperLand.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperLand.Controllers
{
    public class ServiceProviderController : Controller
    {

        private readonly HelperLandContext _helperlandContext = null;
        public ServiceProviderController(HelperLandContext helperlandContext)
        {
            _helperlandContext = helperlandContext;

        }

        public IActionResult Dashboard()
        {
            var u_name = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.FirstName)
                .FirstOrDefault();
            ViewBag.name = u_name;

            return View();
        }

        [HttpGet]
        public IActionResult NewServiceTable()
        {

            var id = _helperlandContext.Users
               .Where(a => a.Email == HttpContext.Session.GetString("username"))
               .Select(a => a.UserId)
               .FirstOrDefault();

            var spZipcode = _helperlandContext.UserAddresses
                .Where(a => a.UserId == id)
                .Select(a => a.PostalCode)
                .FirstOrDefault();

            List<ServiceRequest> newService = _helperlandContext.ServiceRequests
                .Where(a => a.ZipCode == spZipcode && a.Status == null)
                .ToList();

            foreach (var item in newService)
            {
                _helperlandContext.Entry(item).Reference(s => s.User).Load();
                _helperlandContext.Entry(item).Collection(s => s.ServiceRequestAddresses).Load();
            }

            return View(newService);
        }

        //[HttpPost]
        //public IActionResult NewServiceTable()
        //{

        //    var id = _helperlandContext.Users
        //       .Where(a => a.Email == HttpContext.Session.GetString("username"))
        //       .Select(a => a.UserId)
        //       .FirstOrDefault();

        //    var spZipcode = _helperlandContext.UserAddresses
        //        .Where(a => a.UserId == id)
        //        .Select(a => a.PostalCode)
        //        .FirstOrDefault();

        //    List<ServiceRequest> newService = _helperlandContext.ServiceRequests
        //        .Where(a => a.ZipCode == spZipcode && a.Status == null)
        //        .ToList();


        //    return View(newService);
        //}

        [HttpPost]
        public JsonResult AcceptService(int Id)
        {
            var service = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();
            var id = _helperlandContext.Users
              .Where(a => a.Email == HttpContext.Session.GetString("username"))
              .Select(a => a.UserId)
              .FirstOrDefault();
            

            if (service != null)
            {
                //var serDate = service.ServiceStartDate.ToShortDateString();
                //var sameDateService = _helperlandContext.ServiceRequests
                //    .Where(a => a.ServiceProviderId == id && a.ServiceStartDate.ToShortDateString() == serDate)
                //    .FirstOrDefault();

                //var totalTimeOfFirst = Convert.ToDouble(sameDateService.ServiceStartDate.ToString("HH:mm")) + sameDateService.ServiceHours + sameDateService.ExtraHours;
                //var startTime = Convert.ToDouble(service.ServiceStartDate.ToString("HH:mm"));

                //if ((startTime) - (totalTimeOfFirst) <= 1)
                //{
                //    TempData["serviceConcurrentError"] = "Another service request has already been assigned which has time overlap with this service request.You can’t pick this one!";
                //}
                if (service.Status == 1)
                {
                    TempData["serviceAccepteError"] = "This service request is no more available. It has been assigned to another provider.";
                }
                service.Status = 1;
                service.ServiceProviderId = id;
                service.SpacceptedDate = DateTime.Now;
                _helperlandContext.Update(service);
                _helperlandContext.SaveChanges();
            }
            return Json(true);
        }

        public IActionResult UpcomingServiceTable()
        {

            var id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();


            List<ServiceRequest> newService = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceProviderId == id && a.Status == 1)
                .ToList();

            foreach (var item in newService)
            {
                _helperlandContext.Entry(item).Reference(s => s.User).Load();
                _helperlandContext.Entry(item).Collection(s => s.ServiceRequestAddresses).Load();
            }

            return View(newService);
        }

        [HttpPost]
        public JsonResult CompleteService(int Id)
        {
            var id = _helperlandContext.Users
               .Where(a => a.Email == HttpContext.Session.GetString("username"))
               .Select(a => a.UserId)
               .FirstOrDefault();

            var service = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            if (service != null)
            {
                service.Status = 2;
                service.ModifiedDate = DateTime.Now;
                service.ModifiedBy = id;
                _helperlandContext.Update(service);
                _helperlandContext.SaveChanges();
            }
            return Json(true);

        }

        [HttpPost]
        public JsonResult CancelService(int Id)
        {
            var id = _helperlandContext.Users
               .Where(a => a.Email == HttpContext.Session.GetString("username"))
               .Select(a => a.UserId)

               .FirstOrDefault();
            var service = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            if (service != null)
            {
                service.Status = 0;
                service.ModifiedDate = DateTime.Now;
                service.ModifiedBy = id;
                _helperlandContext.Update(service);
                _helperlandContext.SaveChanges();
            }
            return Json(true);

        }

        [HttpGet]
        public IActionResult ServiceHistoryTable()
        {

            var id = _helperlandContext.Users
               .Where(a => a.Email == HttpContext.Session.GetString("username"))
               .Select(a => a.UserId)
               .FirstOrDefault();

            List<ServiceRequest> newService = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceProviderId == id && a.Status == 2)
                .ToList();


            foreach (var item in newService)
            {
                _helperlandContext.Entry(item).Reference(s => s.User).Load();
                _helperlandContext.Entry(item).Collection(s => s.ServiceRequestAddresses).Load();
            }
            //List<ServiceRequest> servicerequests = _helperlandContext.ServiceRequests
            //    .Where(a => a.UserId == id && a.Status == 2)
            //    .ToList();
            //List<User> user = _helperlandContext.Users
            //    //.Where(a=>a.UserId == a.UserId)
            //    .ToList();


            //var serviceRecord = from s in servicerequests
            //                    join u in user on s.UserId equals u.UserId into table1
            //                    from u in table1.ToList()

            //                    select new ServiceViewModel
            //                    {
            //                        user = u,
            //                        servicerequest = s,

            //                    };

            return View(newService);
        }

        [HttpGet]
        public IActionResult Mysetting()
        {
            var u_name = HttpContext.Session.GetString("username");

            var id = _helperlandContext.Users
                .Where(a => a.Email == u_name)
                .Select(a => a.UserId)
                .FirstOrDefault();

            var username = _helperlandContext.Users
                .Where(a => a.UserId == id)
                .Select(a => a.FirstName)
                .FirstOrDefault();
            ViewBag.name = username;

            var avatar = _helperlandContext.Users.Where(a => a.UserId == id)
                .Select(a=>a.UserProfilePicture)
                .FirstOrDefault();
            ViewData["avatarImage"] = avatar;

            User newModel = _helperlandContext.Users.Where(a => a.UserId == id).FirstOrDefault();

            return View(newModel);


            //List<User> users = _helperlandContext.Users.ToList();
            //List<UserAddress> userAddresses = _helperlandContext.UserAddresses.ToList();

            //var employeeRecord = from u in users
            //                     join ad in userAddresses on u.UserId equals ad.UserId into table1
            //                     from ad in table1.ToList()
            //                     select new ProviderViewModel
            //                     {
            //                         user = u,
            //                         userAddress = ad
            //                     };

            //return View(employeeRecord.ToList());

        }

        [HttpPost]
        public IActionResult Mysetting(User model)
        {

            var user = _helperlandContext.Users.Where(a => a.UserId == model.UserId).FirstOrDefault();

            if (user != null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Mobile = model.Mobile;
                user.DateOfBirth = model.DateOfBirth;
                user.Gender = model.Gender.Value;
                user.UserProfilePicture = model.UserProfilePicture.ToString();
               

                _helperlandContext.Users.Update(user);
                _helperlandContext.SaveChanges();
                TempData["spDetail"] = "Your Detail Updated Successfully";
                //return RedirectToAction("Mysetting");
            }
            ViewData["JavaScript"] = "window.location = '" + Url.Page("/ServiceProvider/Mysetting") + "'";
            return View("Mysetting");
        }

        [HttpGet]
        public IActionResult SpAddress()
        {
            var id = _helperlandContext.Users
               .Where(a => a.Email == HttpContext.Session.GetString("username"))
               .Select(a => a.UserId)
               .FirstOrDefault();

            var address = _helperlandContext.UserAddresses
                .Where(a => a.UserId == id)
                .FirstOrDefault();

            if(address != null)
            {
                return View(address);
            }

            else
            {
                return View();
            }
            return View();
        }

        [HttpPost]
        public IActionResult SpAddress(UserAddress model)
        {
            //var address = _helperlandContext.UserAddresses.Where(a => a.AddressId == userAddress.AddressId).FirstOrDefault();
            var id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();
            
            var addId = model.AddressId;

            if(addId == 0)
            {
                UserAddress userAddress = new UserAddress
                {
                    UserId = id,
                    AddressLine1 = model.AddressLine1,
                    AddressLine2 = model.AddressLine2,
                    City = model.City,
                    State = model.State,
                    PostalCode = model.PostalCode,
                    Mobile = model.Mobile,
                    IsDefault = true,
                    IsDeleted = true,
                    Email = HttpContext.Session.GetString("username")
                };

                _helperlandContext.Add(userAddress);
                _helperlandContext.SaveChanges();
                TempData["spNewAdd"] = "New Address added Successfully";
            }

            else
            {
                var address = _helperlandContext.UserAddresses
                    .Where(a => a.AddressId == addId)
                    .FirstOrDefault();

                if(address != null)
                {
                    address.AddressLine1 = model.AddressLine1;
                    address.AddressLine2 = model.AddressLine2;
                    address.PostalCode = model.PostalCode;
                    address.City = model.City;
                    _helperlandContext.UserAddresses.Update(address);
                    _helperlandContext.SaveChanges();
                    TempData["spAdd"] = "Your Address Updated Successfully";
                }
            }
            return RedirectToAction("Mysetting");
        }


        public IActionResult SpPassword()
        {
            return View();
        }

        [HttpPost]

        public IActionResult SpPassword(UserViewModel model)
        {
            var user_name = HttpContext.Session.GetString("username");
            var user = _helperlandContext.Users
                .Where(a => a.Email == user_name)
                .FirstOrDefault();

            var oldPswd = _helperlandContext.Users
                .Where(a => a.Email == user_name)
                .Select(a => a.Password)
                .FirstOrDefault();

            if (oldPswd == Hash.HashPass(model.OldPassword))
            {
                user.Password = Hash.HashPass(model.Password);
                _helperlandContext.Users.Update(user);
                _helperlandContext.SaveChanges();
                TempData["pswdReset"] = "New Password Updated Successfully";

                return RedirectToAction("Mysetting");
            }

            else if (oldPswd != Hash.HashPass(model.OldPassword))
            {
                TempData["pswdError"] = "Your cuurent password does not match please try again";
                return RedirectToAction("Mysetting");
            }

            return RedirectToAction("Mysetting");
        }

        [NonAction]
        public bool isEmailExist(string email)
        {
            var e = _helperlandContext.Users.Where(e => e.Email == email).FirstOrDefault();
            return e != null;
        }

        [NonAction]
        public bool isMobileExist(string mobile)
        {
            var e = _helperlandContext.Users.Where(e => e.Mobile == mobile).FirstOrDefault();
            return e != null;
        }
    }
}
