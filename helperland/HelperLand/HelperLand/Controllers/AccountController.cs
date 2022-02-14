﻿using HelperLand.Data;
using HelperLand.Models;
using HelperLand.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Helpers;
using MailKit.Net.Smtp;
using MailKit;
using MimeKit;
using MailKit.Security;
using MimeKit.Text;

namespace HelperLand.Controllers
{
    public class AccountController : Controller
    {
        HelperLandContext db = new HelperLandContext();
        public IActionResult Index()
        {
            return View();
        }

        [Route("login")]
        [HttpPost]
        public IActionResult Login(UserViewModel model)
        {
            
           
            User user = db.Users.Where(u => u.Email == model.Email && (string.Compare(Hash.HashPass(model.Password), u.Password) == 0)).FirstOrDefault();

            if (user != null)
                {
                    HttpContext.Session.SetString("username", model.Email);

                    return View("~/Views/Home/Index.cshtml");
                }
            

            else
            {
                ViewBag.error = "Invalid Account";
                return View("logout");
            }

        }

        [HttpGet]
        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(UserViewModel model)
        {
            string resetlink = Guid.NewGuid().ToString();
            var account = db.Users.Where(a => a.Email == model.Email).FirstOrDefault();
            
            if(account != null)
            {

                MimeMessage message = new MimeMessage();

                message.From.Add(new MailboxAddress("Helperland", "helperlandservice@gmail.com"));

                message.To.Add(MailboxAddress.Parse(model.Email));

                message.Subject = "Reset Password";

                var lnkHref = "<a href= \"http://localhost:64175" + Url.Action("ResetPassword", "Account") + "/" + resetlink  +  " \" >Reset Password</a>";
                message.Body = new TextPart("html")
                {

                    Text = "Click this link to reset your password <a href=" + lnkHref + "</a>"
                   
                };

                SmtpClient smtp = new SmtpClient();
                try
                {
                    smtp.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate("helperlandservice@gmail.com", "Password@33");
                    smtp.Send(message);
                    TempData["emailSent"] = "Registered Successfully";
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

                account.ReserPasswordLink = resetlink;
                //db.Configuration.ValidateOnSaveEnabled = false;

                db.SaveChanges();

                //db.Users.Where(a => a.Email == model.Email).FirstOrDefault();
                //model.ReserPasswordLink = resetlink;
            }

            else
            {
                ViewBag.msg = "Account not exist";
            }

            return View("~/Views/Home/Index.cshtml");
        }

    
        //[Route("/AccountController/ResetPassword/{id?}")]
        //[HttpGet]
        //public IActionResult ResetPassword(string resetlink)
        //{
        //    //verify resetlink
        //    //find user
        //    //provide reset password page

        //    var user = db.Users.Where(a => a.ReserPasswordLink == resetlink).FirstOrDefault();
        //    if(user!=null)
        //    {
        //        ResetPasswordViewModel resetModel = new ResetPasswordViewModel();
        //        resetModel.resetlink = resetlink;
        //        return View(resetModel);
        //    }
        //    else
        //    {
        //        return StatusCode(404);
        //    }

        //    //return RedirectToAction();
        //}

        
        [HttpGet]
        [Route("/Account/ResetPassword/{id}")]
        public IActionResult ResetPassword(string id)
        {
            var user = db.Users.Where(a => a.ReserPasswordLink == id).FirstOrDefault();
            if(user != null)
            {
                ResetPasswordViewModel resetModel = new ResetPasswordViewModel();
                resetModel.resetlink = id;
                return View(resetModel);
            }
               

            

            //else
            //    {
            //        return StatusCode(404);
            //    }

            return View();
        }

        [HttpPost]
        public  IActionResult ResetPassword(ResetPasswordViewModel model)
        {
            
                var user = db.Users.Where(a => a.ReserPasswordLink == model.resetlink).FirstOrDefault();
                if(user != null)
                {
                    user.Password = Hash.HashPass(model.newPassword);
                    user.ReserPasswordLink = " ";
                    db.Users.Update(user);
                    db.SaveChanges();
                    TempData["pswdReset"] = "New Password Updated Successfully";
                
                }

            return View();
        }


    }
}