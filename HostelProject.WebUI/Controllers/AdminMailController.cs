﻿using HostelProject.WebUI.Models.Mail;
using MailKit.Net.Smtp;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
//using System.Net.Mail;

namespace HostelProject.WebUI.Controllers
{
    public class AdminMailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(AdminMailViewModel model)
        {
            MimeMessage mimeMessage = new MimeMessage();
            MailboxAddress mailboxAddressFrom = new MailboxAddress("HotailerAdmin", "mustafakumru392@gmail.com");
            mimeMessage.From.Add(mailboxAddressFrom);
            MailboxAddress mailboxAddressTo = new MailboxAddress("User", model.ReceiverMail);
            mimeMessage.To.Add(mailboxAddressTo);
            var bodyBuilder= new BodyBuilder();
            bodyBuilder.TextBody= model.Body;
            mimeMessage.Body=bodyBuilder.ToMessageBody();


            mimeMessage.Subject=model.Subject;
            SmtpClient client = new SmtpClient();
            client.Connect("smtp.gmail.com", 587,false);
            client.Authenticate("mustafakumru392@gmail.com", "wddm zwjj dlod guza");
            client.Send(mimeMessage);
            client.Disconnect(true);
            return View();
        }
    }
}
