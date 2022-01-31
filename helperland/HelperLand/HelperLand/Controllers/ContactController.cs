using HelperLand.Data;
using HelperLand.Models;
using HelperLand.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelperLand.Controllers
{
    public class ContactController : Controller
    {
        private readonly HelperlandContext _helperlandContext = null;
        public IHostingEnvironment hostingEnvironment { get; }


        public ContactController(HelperlandContext helperlandContext,
            IHostingEnvironment hostingEnvironment)
        {
            _helperlandContext = helperlandContext;
            this.hostingEnvironment = hostingEnvironment;
        }



        public IActionResult Contact(bool IsSuccess = false)
        {
            ViewBag.isSuccess = IsSuccess; 
            return View();
        }

        [HttpPost]
        public IActionResult Contact(ContactViewModel model)
        {
            if(ModelState.IsValid)
            {
                string uniqueFileName = null;
                if(model.File != null)
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

            }
            return RedirectToAction("Contact", new { IsSuccess = true});
        }
    }
}
