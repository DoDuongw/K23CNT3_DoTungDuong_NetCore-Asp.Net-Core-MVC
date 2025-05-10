using Microsoft.AspNetCore.Mvc;
using DtdLesson02_03.Models;
using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace DtdLesson02_03.Controllers
{
    public class DtdAccountController : Controller
    {
        public IActionResult DtdIndex()
        {
            List<DtdAccount> accounts = new List<DtdAccount>
            {
                new DtdAccount
                {
                    Id = 1,
                    Name = "Pham Thuy Duong",
                    Email = "phamthuyduong@gmail.com",
                    Phone = "0999999999",
                    Address = "Hanoi",
                    Avatar = Url.Content("~/Avatar/anh1.jpg"),
                    Gender = 1,
                    Bio = "My Name Is Small",
                    Birthday = new DateTime(2005, 02, 23)
                }
            };

            return View(accounts);
        }
        [Route("ho-so-cua-toi", Name = "profile")]
        public IActionResult DtdProfile(int? id)
        {
            List<DtdAccount> accounts = new List<DtdAccount>
            {
                new DtdAccount(),
            };
            var account = new DtdAccount
            {
                Id = 1,
                Name = "Pham Thuy Duong",
                Email = "phamthuyduong@gmail.com",
                Phone = "0999999999",
                Address = "Hanoi",
                Avatar = Url.Content("~/Avatar/anh1.jpg"),
                Gender = 1,
                Bio = "My Name Is Small",
                Birthday = new DateTime(2005, 02, 23)
            };

            ViewBag.account = account;
            return View(account);
        }

    }
}