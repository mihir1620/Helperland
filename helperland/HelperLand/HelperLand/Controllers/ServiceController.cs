using HelperLand.Data;
using HelperLand.Models;
using HelperLand.ViewModels;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperLand.Controllers
{
    
    public class ServiceController : Controller
    {
        private readonly HelperLandContext _helperlandContext = null;
       
        //User user = new User();

        public ServiceController(HelperLandContext helperlandContext)
        {
            _helperlandContext = helperlandContext;
            
        }
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
        public JsonResult Check(Zipcode model)
        {
            Zipcode zip = _helperlandContext.Zipcodes.Where(z => z.ZipcodeValue == model.ZipcodeValue).FirstOrDefault();
           
            /*ServiceRequest serviceRequest = new ServiceRequest
            {
                ZipCode = model.ZipcodeValue,
                ServiceStartDate = DateTime.Now,

            };
            db.Add(serviceRequest);
            db.SaveChanges();*/

            if (zip != null)
            {
                ViewBag.zipmsg = "Service Provider is available in your area Please move to next tab to further booking";
                TempData["zipcode"] = model.ZipcodeValue;
                return Json(true);
                
            }
            else
            {
                ViewBag.zipmsg = "We are not providing service in this area. We will notify you if any helper would start working near your area";
            }
            return Json(false);
        }

        [HttpGet]
        public IActionResult Schedule()
        {
            return View("Service");
        }

        [HttpPost]
        public JsonResult Schedule(ServiceViewModel model)
        {

            var id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();

            var z = TempData["zipcode"].ToString();
            ViewBag.name = id;

            //if(model.ServiceStartDate != null)
            {
                //var Time = model.ServiceTime;

                var extra_hrs = (model.ExtraHours) / 2;
                var cost = (decimal)(20 * (model.ServiceHours));
                ServiceRequest newRequest = new ServiceRequest
                {
                    
                    UserId = id,
                    ServiceStartDate = model.ServiceStartDate.Date + model.ServiceTime.TimeOfDay,
                    ServiceHourlyRate = 20,
                    ServiceHours = model.ServiceHours,
                    ExtraHours = extra_hrs,
                    Comments = model.Comments,
                    HasPets =model.HasPets,
                    ZipCode = z,
                    SubTotal = cost,
                    TotalCost = ((decimal)(20 * (extra_hrs))) + cost,
                    ModifiedDate = model.ServiceStartDate,
                    Distance = 1
                };
                _helperlandContext.Add(newRequest);
                _helperlandContext.SaveChanges();

                var serviceReqId = _helperlandContext.ServiceRequests
                   .Where(a => a.UserId == id)
                   .OrderByDescending(a => a)
                   .Select(a => a.ServiceRequestId)
                   .FirstOrDefault();

                return Json(true);
            }

            return Json(true);
           
        }

        [HttpGet]
        public IActionResult Details()
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

        [HttpPost]
        public JsonResult Details(ServiceViewModel model, string Address_radio, string action)
        {
            
            var u_name = HttpContext.Session.GetString("username");

            var id = _helperlandContext.Users
                .Where(a => a.Email == u_name)
                .Select(a => a.UserId)
                .FirstOrDefault();

            var serviceReqId = _helperlandContext.ServiceRequests
                   .Where(a => a.UserId == id)
                   .OrderByDescending(a=>a)
                   .Select(a => a.ServiceRequestId)
                   .FirstOrDefault();

            

            if (action == "addSerAdd")
            {
                int Address_id = int.Parse(Address_radio);

                UserAddress newUserAdd = _helperlandContext.UserAddresses
                                         .Where(a => a.AddressId == Address_id)
                                         .FirstOrDefault();

                ServiceRequestAddress serviceRequestAddress = new ServiceRequestAddress
                {
                    ServiceRequestId = serviceReqId,
                    AddressLine1 = newUserAdd.AddressLine1,
                    AddressLine2 = newUserAdd.AddressLine2,
                    City = newUserAdd.City,
                    //State = newUserAdd.State,
                    PostalCode = newUserAdd.PostalCode,
                    Mobile = newUserAdd.Mobile
                };
                TempData["bookingId"] = serviceReqId;
                _helperlandContext.Add(serviceRequestAddress);
                _helperlandContext.SaveChanges();
                return Json(true);
            }

            else 
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
                    IsDeleted = true
                };
                TempData["bookingId"] = serviceReqId;
                _helperlandContext.Add(userAddress);
                _helperlandContext.SaveChanges();
                
                return Json(true);
               
            }

            return Json(false);
        }

        //public IActionResult Details(FormCollection frm)
        //{
        //    string radio = frm["Address_radio"].ToString();
        //    int Address_id = int.Parse("radio");
        //    UserAddress newUserAdd = _helperlandContext.UserAddresses
        //                             .Where(a => a.AddressId == Address_id)
        //                             .FirstOrDefault();

        //    ServiceRequestAddress serviceRequestAddress = new ServiceRequestAddress
        //    {
        //        ServiceRequestId = 51,
        //        AddressLine1 = newUserAdd.AddressLine1,
        //        AddressLine2 = newUserAdd.AddressLine2,
        //        City = newUserAdd.City,
        //        State = newUserAdd.State,
        //        PostalCode = newUserAdd.PostalCode,
        //        Mobile = newUserAdd.Mobile
        //    };
        //    _helperlandContext.Add(serviceRequestAddress);
        //    _helperlandContext.SaveChanges();
        //    return View("Service");
        //}

        public IActionResult payment()
        {
            var u_name = HttpContext.Session.GetString("username");

            var id = _helperlandContext.Users
                .Where(a => a.Email == u_name)
                .Select(a => a.UserId)
                .FirstOrDefault();

            var serviceReqId = _helperlandContext.ServiceRequests
                   .Where(a => a.UserId == id)
                   .OrderByDescending(a => a)
                   .Select(a => a.ServiceRequestId)
                   .FirstOrDefault();

            var zip = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == serviceReqId)
                .Select(a => a.ZipCode)
                .FirstOrDefault();

            var serviceProviderMail = _helperlandContext.Users
                .Where(a => a.ZipCode == zip && a.UserTypeId == 2)
                .Select(a => a.Email)
                .FirstOrDefault();

            MimeMessage message = new MimeMessage();

            message.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));

            message.To.Add(MailboxAddress.Parse(serviceProviderMail));

            message.Subject = "New Service";

            string host = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";
            
            message.Body = new TextPart("html")
            {

                Text = "Dear Service Provider New service is avilable in your area."

            };

            SmtpClient smtp = new SmtpClient();
            try
            {
                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                smtp.Authenticate("helperlandservice@gmail.com", "Password@33");
                smtp.Send(message);
                
            }
            catch (Exception er)
            {
                Console.WriteLine(er.Message);
            }
            finally
            {
                smtp.Disconnect(true);
                smtp.Dispose();
            }

            ViewBag.bookId = serviceReqId;
            return View("service");
        }
    }
}
