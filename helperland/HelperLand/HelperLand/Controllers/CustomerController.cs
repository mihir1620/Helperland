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
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;
using System.Text;
using System.Threading.Tasks;
using OfficeOpenXml;

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

           // var serviceReq1 = _helperlandContext.ServiceRequests
           //.Where(a => a.UserId == id).Select(s => new { s, s.ServiceProvider});

            List<ServiceRequest> serviceReq = _helperlandContext.ServiceRequests
            .Where(a => a.UserId == id).ToList();

            foreach(var item in serviceReq)
            {
                _helperlandContext.Entry(item).Reference(s => s.ServiceProvider).Load();
                _helperlandContext.Entry(item).Collection(s => s.Ratings).Load();
            }
            //ViewData["JavaScript"] = "window.location = '" + Url.Page("/Customer/Dashboard") + "'";
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


            foreach (var item in serviceReq)
            {
                _helperlandContext.Entry(item).Reference(s => s.ServiceProvider).Load();
            }

            return View(serviceReq);
        }

        [HttpPost]
        public JsonResult RateSp(int Id, int User, int ServiceProvider, string Feedback, int Ontime, int Friend, int QOS)
        {
            var ser = _helperlandContext.Ratings
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();


            var ratings = (Ontime + Friend + QOS)/3;

            if(ser == null)
            {
                Rating newRating = new Rating
                {
                    ServiceRequestId = Id,
                    RatingFrom = User,
                    RatingTo = ServiceProvider,
                    Ratings = ratings,
                    Comments = Feedback,
                    OnTimeArrival = Ontime,
                    Friendly = Friend,
                    QualityOfService = QOS,
                    RatingDate = DateTime.Now
                };
                _helperlandContext.Ratings.Add(newRating);
                _helperlandContext.SaveChanges();
                TempData["RateMsg"] = "Thanks for your rating";
                return Json(true);
            }

            if(ser != null)
            {
                ser.ServiceRequestId = Id;
                ser.RatingFrom = User;
                ser.RatingTo = ServiceProvider;
                ser.Ratings = ratings;
                ser.OnTimeArrival = Ontime;
                ser.Friendly = Friend;
                ser.QualityOfService = QOS;
                ser.Comments = Feedback;
                ser.RatingDate = DateTime.Now;

                _helperlandContext.Ratings.Update(ser);
                _helperlandContext.SaveChanges();
                TempData["RateMsg"] = "Thanks for your rating";
                return Json(true);
            }
            return Json(true);
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
            //if (isEmail)
            //{
            //    ModelState.AddModelError("EmailExist", "Email already exist");
            //    return View();
            //}

            //if (isPhone)
            //{
            //    ModelState.AddModelError("MobileExist", "Mobile number already exist");
            //    return View();
            //}
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

            var spId = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .Select(a => a.ServiceProviderId)
                .FirstOrDefault();

            if (service != null)
            {
                service.Status = 0;
                _helperlandContext.Update(service);
                _helperlandContext.SaveChanges();

                var spEmail = _helperlandContext.Users
               .Where(a => a.UserId == spId)
               .Select(a => a.Email)
               .FirstOrDefault();

                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
                message.To.Add(MailboxAddress.Parse(spEmail));
                message.Subject = "Service Cancellation";
                string host = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";

                message.Body = new TextPart("html")
                {

                    Text = "Dear Service Provider service with ID:"+ Id +" is cancelled by user."

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

            var spId = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .Select(a => a.ServiceProviderId)
                .FirstOrDefault();

            var resheduled_dt = ServiceDate.Date + ServiceTime.TimeOfDay;

            

            if (service != null)
            {
                if(service.ServiceProviderId == null)
                {
                    service.ServiceStartDate = resheduled_dt;
                    _helperlandContext.Update(service);
                    _helperlandContext.SaveChanges();
                }

                else if(service.ServiceProviderId != null)
                {
                    List<ServiceRequest> spService = _helperlandContext.ServiceRequests
                        .Where(a => a.ServiceProviderId == service.ServiceProviderId)
                        .ToList();

                  foreach(var item in spService)
                    {
                        var date = item.ServiceStartDate.Date;
                        if(date == ServiceDate)
                        {
                            var total_time = item.ServiceHours + item.ExtraHours;
                            decimal t = (decimal)total_time;
                            TimeSpan span = new TimeSpan(0, Convert.ToInt32(total_time), Convert.ToInt32(t - Math.Truncate(t)) * 6, 0);
                            var time = item.ServiceStartDate.Add(span);


                           var result =  DateTime.Compare(time, ServiceTime);
                            
                            if(result < 0)
                            {
                                service.ServiceStartDate = resheduled_dt;
                                _helperlandContext.Update(service);
                                _helperlandContext.SaveChanges();
                            }
                            else
                            {
                                TempData["ResheduleError"] = "Another service request has been assigned to the service provider on this date.Either choose another date or pick up a different time slot";
                                return Json(false);
                            }
                        }
                    }
                
                   var spEmail = _helperlandContext.Users
                   .Where(a => a.UserId == spId)
                   .Select(a => a.Email)
                   .FirstOrDefault();

                    MimeMessage message = new MimeMessage();
                    message.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
                    message.To.Add(MailboxAddress.Parse(spEmail));
                    message.Subject = "Service Reschedule";
                    string host = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";

                    message.Body = new TextPart("html")
                    {

                        Text = "Dear Service Provider service with ID:"+ Id +" is rescheduled by user with new date and time which is" + resheduled_dt + "."

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
                }
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
                newAdd.AddressLine1 = addLine1;
                newAdd.AddressLine2 = addLine2;
                newAdd.City = userCity;
                newAdd.PostalCode = userPostalcode;
                newAdd.Mobile = userMobile;
                _helperlandContext.UserAddresses.Update(newAdd);
                _helperlandContext.SaveChanges();
            }

            return Json(true);
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

            else if(oldPswd != Hash.HashPass(model.OldPassword))
            {
                TempData["pswdError"] = "Your cuurent password does not match please try again";
                return RedirectToAction("Mysetting");
            }

            return RedirectToAction("Mysetting");
        }

        [HttpPost]
        public FileResult Export()
        {
            var id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();

            List<ServiceRequest> serviceReq = _helperlandContext.ServiceRequests
                    .Where(a => a.UserId == id && (a.Status == 0 || a.Status == 2))
                    .ToList();

            foreach (var item in serviceReq)
            {
                _helperlandContext.Entry(item).Reference(s => s.ServiceProvider).Load();
            }

            ExcelPackage Ep = new ExcelPackage();
            ExcelWorksheet Sheet = Ep.Workbook.Worksheets.Add("Report");
            Sheet.Cells["A1"].Value = "Service Id";
            Sheet.Cells["B1"].Value = "Service Startdate";
            Sheet.Cells["C1"].Value = "Service Provider";
            Sheet.Cells["D1"].Value = "Payment";
            Sheet.Cells["E1"].Value = "Status";

            int row = 2;
            foreach (var item in serviceReq)
            {

                Sheet.Cells[string.Format("A{0}", row)].Value = item.ServiceRequestId;
                Sheet.Cells[string.Format("B{0}", row)].Value = item.ServiceStartDate.ToShortDateString();
                if(item.ServiceProvider != null)
                {
                    Sheet.Cells[string.Format("C{0}", row)].Value = item.ServiceProvider.FirstName;
                }
                else
                {
                    Sheet.Cells[string.Format("C{0}", row)].Value = item.ServiceProviderId;
                }
                if(item.Status == null)
                {
                    Sheet.Cells[string.Format("D{0}", row)].Value = "Pending";

                }
                if (item.Status == 0)
                {
                    Sheet.Cells[string.Format("D{0}", row)].Value = "Cancelled";

                }
                if (item.Status == 2)
                {
                    Sheet.Cells[string.Format("D{0}", row)].Value = "Completed";

                }
                Sheet.Cells[string.Format("E{0}", row)].Value = item.TotalCost + "₹";
                row++;
            }

            Sheet.Cells["A:AZ"].AutoFitColumns();

            using (MemoryStream stream = new MemoryStream())
            {
                Ep.SaveAs(stream);
                return File(stream.ToArray(), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", "ServiceHistory.xlsx");
            }
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
