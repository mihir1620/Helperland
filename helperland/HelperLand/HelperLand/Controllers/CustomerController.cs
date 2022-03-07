using ClosedXML.Excel;
using HelperLand.Data;
using HelperLand.Models;
using HelperLand.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelperLand.Controllers
{
    public class CustomerController : Controller
    {
        private readonly HelperLandContext _helperlandContext = null;
        public CustomerController(HelperLandContext helperlandContext)
        {
            _helperlandContext = helperlandContext;

        }

        [HttpGet]
        public IActionResult Dashboard()
        {
            ViewBag.name = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.FirstName)
                .FirstOrDefault();
            return View();
        }

        [HttpGet]
        public IActionResult DashboardTable()
        {
            var u_name = HttpContext.Session.GetString("username");
            ViewBag.name = u_name;
            var id = _helperlandContext.Users
               .Where(a => a.Email == u_name)
               .Select(a => a.UserId)
               .FirstOrDefault();


            List<ServiceRequest> serviceReq = _helperlandContext.ServiceRequests
            .Where(a => a.UserId == id)
            .ToList();

            //var query = from service in _helperlandContext.ServiceRequests
            //            join user in _helperlandContext.Users on service.UserId equals user.UserId;


            return View(serviceReq);
        }

        [HttpPost]
        public IActionResult DashboardTable(ServiceViewModel model)
        {
            return View();
        }

        [HttpGet]
        public IActionResult Servicehistory()
        {
            var u_name = _helperlandContext.Users
                .Where(a=>a.Email == HttpContext.Session.GetString("username"))
                .Select(a=>a.FirstName)
                .FirstOrDefault();
            ViewBag.name = u_name;

            return View();
        }

        [HttpGet]
        public IActionResult ServiceHistoryTable()
        {
            var id = _helperlandContext.Users
               .Where(a => a.Email == HttpContext.Session.GetString("username"))
               .Select(a => a.UserId)
               .FirstOrDefault();


            List<ServiceRequest> serviceReq = _helperlandContext.ServiceRequests
            .Where(a => a.UserId == id)
            .ToList();

            return View(serviceReq);
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

           User newModel = _helperlandContext.Users.Where(a => a.UserId == id).FirstOrDefault();

            return View(newModel);
        }

        [HttpPost]
        public IActionResult Mysetting(User model)
        {
            var isPhone = isMobileExist(model.Mobile);
            var isEmail = isEmailExist(model.Email);
            if (isEmail)
            {
                ModelState.AddModelError("EmailExist", "Email already exist");
                return View();
            }

            if (isPhone)
            {
                ModelState.AddModelError("MobileExist", "Mobile number already exist");
                return View();
            }
            var user = _helperlandContext.Users.Where(a => a.UserId == model.UserId).FirstOrDefault();

            if(user != null)
            {
                user.FirstName = model.FirstName;
                user.LastName = model.LastName;
                user.Mobile = model.Mobile;
                user.DateOfBirth = model.DateOfBirth;

                _helperlandContext.Update(user);
                _helperlandContext.SaveChanges();

            }

            return View();
        }

        [HttpPost]
        public JsonResult DeleteAddress(int Id)
        {

            var user = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();

            UserAddress deleteAddress = _helperlandContext.UserAddresses
                .Single(a => a.AddressId == Id);

                _helperlandContext.UserAddresses.Remove(deleteAddress);
                _helperlandContext.SaveChanges();
            
            return Json(true);
        }


        [HttpGet]

        public IActionResult User_Address()
        {
            var u_name = HttpContext.Session.GetString("username");

            var id = _helperlandContext.Users
                .Where(a => a.Email == u_name)
                .Select(a => a.UserId)
                .FirstOrDefault();
            ViewBag.name = u_name;

            List<UserAddress> newAdd = _helperlandContext.UserAddresses
            .Where(a => a.UserId == id)
            .ToList();

            return View(newAdd);
        }

        public JsonResult getService(int Id)
        {
            var service = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            var time = service.ServiceHours + service.ExtraHours;

            var address = _helperlandContext.ServiceRequestAddresses
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            var serviceAdd = address.AddressLine1 + " " + address.AddressLine2 + " " + address.PostalCode + " " + address.City;
            
            return Json(new 
            {   
                serviceId=service.ServiceRequestId, 
                serviceDate=service.ServiceStartDate.ToString("dd/MM/yyyy") ,
                serviceTime=service.ServiceStartDate.ToString("HH:mm"),
                duration= time, 
                netAmount=service.TotalCost, 
                phone=address.Mobile, 
                email=address.Email, 
                serviceAddress = serviceAdd, 
                comments = service.Comments
            });
        }

        [HttpPost]
        public JsonResult CancelService(int Id)
        {
            var service = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            if (service != null)
            {
                service.Status = 0;
                _helperlandContext.Update(service);
                _helperlandContext.SaveChanges();
            }
            return Json(true);
        }

        [HttpPost]
        public JsonResult RescheduleService(int Id, DateTime ServiceDate, DateTime ServiceTime)
        {
            var id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();

            var service = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            if(service != null)
            {
                service.ServiceStartDate = ServiceDate.Date + ServiceTime.TimeOfDay;
                _helperlandContext.Update(service);
                _helperlandContext.SaveChanges();
            }
            return Json(true);
        }

        [HttpGet]
        public IActionResult AddressPopup()
        {

            return View();
        }

        [HttpPost]
        public IActionResult AddressPopup(ServiceViewModel model)
        {
            var u_name = HttpContext.Session.GetString("username");

            var id = _helperlandContext.Users
                .Where(a => a.Email == u_name)
                .Select(a => a.UserId)
                .FirstOrDefault();

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
                IsDeleted = true
            };
            _helperlandContext.Add(userAddress);
            _helperlandContext.SaveChanges();
        
            return RedirectToAction("Mysetting");
        }

        [HttpGet]
        public JsonResult EditAddress(int Id)
        {

            UserAddress newAdd = _helperlandContext.UserAddresses
            .Where(a => a.AddressId == Id)
            .First();

            return Json(new {
                adressId = newAdd.AddressId,
                addressLine1 = newAdd.AddressLine1,
                addressLine2 = newAdd.AddressLine2,
                postalcode = newAdd.PostalCode,
                city = newAdd.City,
                mobile = newAdd.Mobile

            });
        }

        [HttpPost]
        public JsonResult SaveEditAddress(int Id,string addLine1, string addLine2, string userCity, string userPostalcode, string userMobile)
        {
            var user_id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();

            UserAddress newAdd = _helperlandContext.UserAddresses
                .Where(a => a.AddressId == Id && a.UserId == user_id)
                .FirstOrDefault();

            if(newAdd != null)
            {
                //newAdd.AddressId = Id;
                newAdd.AddressLine1 = addLine1;
                newAdd.AddressLine2 = addLine2;
                newAdd.City = userCity;
                newAdd.PostalCode = userPostalcode;
                newAdd.Mobile = userMobile;
                _helperlandContext.UserAddresses.Update(newAdd);
                _helperlandContext.SaveChanges();
                return Json(true);
            }   
            return Json(false);
        }

        [HttpGet]

        public IActionResult User_pswd()
        {
            return View();
        }

        [HttpPost]

        public IActionResult User_pswd(UserViewModel model)
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

            else
            {
                ViewBag.pswdError = "Your cuurent password does not match please try again";
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
