using HelperLand.Data;
using HelperLand.Models;
using HelperLand.ViewModels;
using MailKit.Net.Smtp;
using MailKit.Security;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MimeKit;
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


                User admin = _helperlandContext.Users
                    .Where(a => a.UserTypeId == 0)
                    .FirstOrDefault();

                MimeMessage message = new MimeMessage();
                message.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
                message.To.Add(MailboxAddress.Parse(admin.Email));
                message.Subject = "New Service";

                message.Body = new TextPart("html")
                {
                    Text = "Hello "+ admin.FirstName+ "<br><br> we have recieved new message from contact-us page <br><br> Phone no:" + model.PhoneNumber + "<br><br> Email:" + model.Email + "<br><br> Subject:" + model.Subject + "<br><br>"
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

                var contactId = _helperlandContext.ContactUs
                    .Where(a => a.Email == model.Email)
                    .OrderByDescending(a => a)
                    .Select(a => a.ContactUsId)
                    .FirstOrDefault();

                MimeMessage message1 = new MimeMessage();
                message1.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));
                message1.To.Add(MailboxAddress.Parse(model.Email));
                message1.Subject = "New Service";

                message1.Body = new TextPart("html")
                {
                    Text = "Hello " + model.Name + "<br><br>Thank you very much for your message, which we are happy to answer. You will receive an answer from us as soon as possible. <br><br> Our system automatically generates a transaction number for each request. If you have any questions, please note the following numbers:"+ contactId + "."
                };

                SmtpClient smtp1 = new SmtpClient();
                try
                {
                    smtp1.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    smtp1.Authenticate("helperlandservice@gmail.com", "Password@33");
                    smtp1.Send(message1);

                }
                catch (Exception er)
                {
                    Console.WriteLine(er.Message);
                }
                finally
                {
                    smtp1.Disconnect(true);
                    smtp1.Dispose();
                }

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

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
