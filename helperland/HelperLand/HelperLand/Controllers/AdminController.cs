using HelperLand.Data;
using HelperLand.Models;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelperLand.Controllers
{
    public class AdminController : Controller
    {
        private readonly HelperLandContext _helperlandContext = null;
        public AdminController(HelperLandContext helperlandContext)
        {
            _helperlandContext = helperlandContext;

        }

        public IActionResult Dashboard()
        {
            var u_name = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.FirstName)
                .FirstOrDefault();

            ViewData["admin_name"] = u_name;


            return View();
        }

        public IActionResult AdminServiceRequestsTable()
        {

            List<ServiceRequest> allReq = _helperlandContext.ServiceRequests
                .Where(a=>a.ServiceRequestId >100 )
                .ToList();

            foreach (var item in allReq)
            {
                _helperlandContext.Entry(item).Reference(s => s.ServiceProvider).Load();
                _helperlandContext.Entry(item).Collection(s => s.Ratings).Load();
                _helperlandContext.Entry(item).Reference(s => s.User).Load();
                _helperlandContext.Entry(item).Collection(s => s.ServiceRequestAddresses).Load();
            }


            return View(allReq);
        }

        [HttpGet]
        public JsonResult EditService(int Id)
        {
            ServiceRequest adminService = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            ServiceRequestAddress adminServiceAddress = _helperlandContext.ServiceRequestAddresses
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            return Json(new
            {
                serviceDate = adminService.ServiceStartDate.ToString("yyyy/MM/dd"),
                serviceTime = adminService.ServiceStartDate.ToString("H:mm"),
                addressLine1 = adminServiceAddress.AddressLine1,
                addressLine2 = adminServiceAddress.AddressLine2,
                postalcode = adminServiceAddress.PostalCode,
                city = adminServiceAddress.City,
            });
        }

        [HttpPost]
        public JsonResult EditService(int Id, DateTime ServiceDate, DateTime ServiceTime, string NewAddressLine1, string NewAddressLine2, string NewPostalcode, string NewCity)
        {
            var admin_id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();

            var service = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            var serviceReqAdd = _helperlandContext.ServiceRequestAddresses
                .Where(a => a.ServiceRequestId == Id)
                .FirstOrDefault();

            var userId = _helperlandContext.ServiceRequests
                .Where(a => a.ServiceRequestId == Id)
                .Select(a => a.UserId)
                .FirstOrDefault();

            var resheduled_dt = ServiceDate.Date + ServiceTime.TimeOfDay;

            if (service != null )
            {
                if (service.ServiceProviderId == null)
                {
                    service.ServiceStartDate = resheduled_dt;
                    service.ModifiedBy = admin_id;
                    service.ModifiedDate = DateTime.Now;
                    _helperlandContext.ServiceRequests.Update(service);


                    serviceReqAdd.AddressLine1 = NewAddressLine1;
                    serviceReqAdd.AddressLine2 = NewAddressLine2;
                    serviceReqAdd.PostalCode = NewPostalcode;
                    serviceReqAdd.City = NewCity;
                    _helperlandContext.ServiceRequestAddresses.Update(serviceReqAdd);
                    _helperlandContext.SaveChanges();

                    var userEmail = _helperlandContext.Users
                                       .Where(a => a.UserId == userId)
                                       .Select(a => a.Email)
                                       .FirstOrDefault();

                    MimeMessage messageforCust = new MimeMessage();
                    messageforCust.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
                    messageforCust.To.Add(MailboxAddress.Parse(userEmail));
                    messageforCust.Subject = "Service Reschedule";
                    string host = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";

                    messageforCust.Body = new TextPart("html")
                    {

                        Text = "Dear Customer service with ID:" + Id + " is rescheduled by admin with new date and time which is" + resheduled_dt + "."

                    };

                    SmtpClient smtp = new SmtpClient();
                    try
                    {
                        smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                        smtp.Authenticate("helperlandservice@gmail.com", "Password@33");
                        smtp.Send(messageforCust);

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

                    return Json(true);
                }

                else if (service.ServiceProviderId != null)
                {
                    List<ServiceRequest> spService = _helperlandContext.ServiceRequests
                        .Where(a => a.ServiceProviderId == service.ServiceProviderId)
                        .ToList();

                    var spId = _helperlandContext.Users
                            .Where(a => a.UserId == service.ServiceProviderId)
                            .Select(a => a.UserId)
                            .FirstOrDefault();

                    foreach (var item in spService)
                    {


                        var date = item.ServiceStartDate.Date;
                        if (date == ServiceDate)
                        {
                            int result = DateTime.Compare(item.ServiceStartDate.AddHours(Convert.ToDouble(item.ServiceHours + item.ExtraHours)), service.ServiceStartDate);

                            if (result < 0)
                            {
                                    service.ServiceStartDate = resheduled_dt;
                                    service.ModifiedBy = admin_id;
                                    service.ModifiedDate = DateTime.Now;
                                    _helperlandContext.ServiceRequests.Update(service);


                                    serviceReqAdd.AddressLine1 = NewAddressLine1;
                                    serviceReqAdd.AddressLine2 = NewAddressLine2;
                                    serviceReqAdd.PostalCode = NewPostalcode;
                                    serviceReqAdd.City = NewCity;
                                    _helperlandContext.ServiceRequestAddresses.Update(serviceReqAdd);
                                    _helperlandContext.SaveChanges();

                                //var userEmail = _helperlandContext.Users
                                //      .Where(a => a.UserId == userId)
                                //      .Select(a => a.Email)
                                //      .FirstOrDefault();

                                //MimeMessage messageforCust = new MimeMessage();
                                //messageforCust.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
                                //messageforCust.To.Add(MailboxAddress.Parse(userEmail));
                                //messageforCust.Subject = "Service Reschedule";
                                //string host = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";

                                //messageforCust.Body = new TextPart("html")
                                //{

                                //    Text = "Dear Customer service with ID:" + Id + " is rescheduled by admin with new date and time which is" + resheduled_dt + "."

                                //};

                                //SmtpClient smtp = new SmtpClient();
                                //try
                                //{
                                //    smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                                //    smtp.Authenticate("helperlandservice@gmail.com", "Password@33");
                                //    smtp.Send(messageforCust);

                                //}
                                //catch (Exception er)
                                //{
                                //    Console.WriteLine(er.Message);
                                //}
                                //finally
                                //{
                                //    smtp.Disconnect(true);
                                //    smtp.Dispose();
                                //}

                                //var spEmail = _helperlandContext.Users
                                //    .Where(a => a.UserId == spId)
                                //    .Select(a => a.Email)
                                //    .FirstOrDefault();

                                //MimeMessage messageforSP = new MimeMessage();
                                //messageforSP.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
                                //messageforSP.To.Add(MailboxAddress.Parse(spEmail));
                                //messageforSP.Subject = "Service Reschedule";

                                //messageforSP.Body = new TextPart("html")
                                //{

                                //    Text = "Dear Service Provider service with ID:" + Id + " is rescheduled by admin with new date and time which is" + resheduled_dt + "."

                                //};

                                //SmtpClient smtp1 = new SmtpClient();
                                //try
                                //{
                                //    smtp1.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                                //    smtp1.Authenticate("helperlandservice@gmail.com", "Password@33");
                                //    smtp1.Send(messageforSP);

                                //}
                                //catch (Exception er)
                                //{
                                //    Console.WriteLine(er.Message);
                                //}
                                //finally
                                //{
                                //    smtp.Disconnect(true);
                                //    smtp.Dispose();
                                //}

                                return Json(true);
                                }
                            else
                            {
                                TempData["ResheduleError"] = "Another service request has been assigned to the service provider on this date.Either choose another date or pick up a different time slot";
                                return Json(false);
                            }
                        }

                        else if (date != ServiceDate)
                        {

                                service.ServiceStartDate = resheduled_dt;
                                service.ModifiedBy = admin_id;
                                service.ModifiedDate = DateTime.Now;
                                _helperlandContext.ServiceRequests.Update(service);

                                serviceReqAdd.AddressLine1 = NewAddressLine1;
                                serviceReqAdd.AddressLine2 = NewAddressLine2;
                                serviceReqAdd.PostalCode = NewPostalcode;
                                serviceReqAdd.City = NewCity;
                                _helperlandContext.ServiceRequestAddresses.Update(serviceReqAdd);
                                _helperlandContext.SaveChanges();

                            var userEmail = _helperlandContext.Users
                                  .Where(a => a.UserId == userId)
                                  .Select(a => a.Email)
                                  .FirstOrDefault();

                            MimeMessage messageforCust = new MimeMessage();
                            messageforCust.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
                            messageforCust.To.Add(MailboxAddress.Parse(userEmail));
                            messageforCust.Subject = "Service Reschedule";
                            string host = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";

                            messageforCust.Body = new TextPart("html")
                            {

                                Text = "Dear Customer service with ID:" + Id + " is rescheduled by admin with new date and time which is" + resheduled_dt + "."

                            };

                            SmtpClient smtp = new SmtpClient();
                            try
                            {
                                smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                                smtp.Authenticate("helperlandservice@gmail.com", "Password@33");
                                smtp.Send(messageforCust);

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

                            var spEmail = _helperlandContext.Users
                                .Where(a => a.UserId == spId)
                                .Select(a => a.Email)
                                .FirstOrDefault();

                            MimeMessage messageforSP = new MimeMessage();
                            messageforSP.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
                            messageforSP.To.Add(MailboxAddress.Parse(spEmail));
                            messageforSP.Subject = "Service Reschedule";

                            messageforSP.Body = new TextPart("html")
                            {

                                Text = "Dear Service Provider service with ID:" + Id + " is rescheduled by admin with new date and time which is" + resheduled_dt + "."

                            };

                            SmtpClient smtp1 = new SmtpClient();
                            try
                            {
                                smtp1.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                                smtp1.Authenticate("helperlandservice@gmail.com", "Password@33");
                                smtp1.Send(messageforSP);

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

                            return Json(true);

                        }
                    }
                }
            }
            return Json(true);
        }


        public IActionResult UserManagementTable()
        {
            List<User> users = _helperlandContext.Users
                .ToList();

            foreach(var item in users)
            {
                _helperlandContext.Entry(item).Collection(s => s.UserAddresses).Load();
            }
            return View(users);
        }

        [HttpPost]
        public JsonResult ActivateUser(int Id)
        {
            var admin_id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();

            var user = _helperlandContext.Users
                .Where(a => a.UserId == Id)
                .FirstOrDefault();

            if(user != null)
            {
                user.IsActive = true;
                user.ModifiedDate = DateTime.Now;
                user.ModifiedBy = admin_id;
                _helperlandContext.Users.Update(user);
                _helperlandContext.SaveChanges();
                return Json(true);
            }

            else
            {
                return Json(false);
            }

            return Json(true);
        }

        [HttpPost]
        public JsonResult DeactivateUser(int Id)
        {
            var admin_id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();

            var user = _helperlandContext.Users
                .Where(a => a.UserId == Id)
                .FirstOrDefault();

            if (user != null)
            {
                user.IsActive = false;
                user.ModifiedDate = DateTime.Now;
                user.ModifiedBy = admin_id;
                _helperlandContext.Users.Update(user);
                _helperlandContext.SaveChanges();
                return Json(true);
            }

            else
            {
                return Json(false);
            }

            return Json(true);
        }

        [HttpPost]
        public JsonResult CancelService(int Id)
        {
            var admin_id = _helperlandContext.Users
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
                service.ModifiedBy = admin_id;
                _helperlandContext.ServiceRequests.Update(service);
                _helperlandContext.SaveChanges();
                return Json(true);
            }

            else
            {
                return Json(false);
            }

            return Json(true);
        }


        [HttpPost]
        public JsonResult ApproveServiceProvider(int Id)
        {
            var admin_id = _helperlandContext.Users
                .Where(a => a.Email == HttpContext.Session.GetString("username"))
                .Select(a => a.UserId)
                .FirstOrDefault();

            var user = _helperlandContext.Users
                .Where(a => a.UserId == Id)
                .FirstOrDefault();

            if (user != null)
            {
                user.IsApproved = true;
                user.ModifiedDate = DateTime.Now;
                user.ModifiedBy = admin_id;
                _helperlandContext.Users.Update(user);
                _helperlandContext.SaveChanges();
                return Json(true);
            }

            else
            {
                return Json(false);
            }

            return Json(true);
        }

    }
}





//var spEmail = _helperlandContext.Users
//                   .Where(a => a.UserId == spId)
//                   .Select(a => a.Email)
//                   .FirstOrDefault();

//var userEmail = _helperlandContext.Users
//.Where(a => a.UserId == userId)
//.Select(a => a.Email)
//.FirstOrDefault();

//MimeMessage messageforSP = new MimeMessage();
//MimeMessage messageforUser = new MimeMessage();
//messageforSP.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
//messageforSP.To.Add(MailboxAddress.Parse(spEmail));
//messageforSP.Subject = "Service Reschedule";
//messageforUser.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
//messageforUser.To.Add(MailboxAddress.Parse(userEmail));
//messageforUser.Subject = "Service Reschedule";
//string host = $"{HttpContext.Request.Scheme}://{HttpContext.Request.Host}";

//messageforSP.Body = new TextPart("html")
//{

//    Text = "Dear Service Provider service with ID:" + Id + " is rescheduled by admin with new date and time which is" + resheduled_dt + "."

//};

//messageforUser.Body = new TextPart("html")
//{

//    Text = "Dear User service with ID:" + Id + " is rescheduled by admin with new date and time which is" + resheduled_dt + "."

//};

//SmtpClient smtp = new SmtpClient();
//SmtpClient smtp1 = new SmtpClient();
//try
//{
//    smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
//    smtp.Authenticate("helperlandservice@gmail.com", "Password@33");
//    smtp.Send(messageforSP);

//}
//catch (Exception er)
//{
//    Console.WriteLine(er.Message);
//}
//finally
//{
//    smtp.Disconnect(true);
//    smtp.Dispose();
//}
//try
//{
//    smtp1.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
//    smtp1.Authenticate("helperlandservice@gmail.com", "Password@33");
//    smtp1.Send(messageforUser);

//}
//catch (Exception er)
//{
//    Console.WriteLine(er.Message);
//}
//finally
//{
//    smtp.Disconnect(true);
//    smtp.Dispose();
//}


