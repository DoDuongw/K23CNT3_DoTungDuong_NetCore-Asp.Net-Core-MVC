using System.Diagnostics;
using DtdLesson05.Models;
using DtdLesson05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace DtdLesson05.Controllers
{
    public class DtdHomeController : Controller
    {
        private readonly ILogger<DtdHomeController> _logger;

        public DtdHomeController(ILogger<DtdHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult DtdIndex()
        {
            return View();
        }

        public IActionResult DtdAbout()
        {
            DtdMember dtdMember = new DtdMember();
            dtdMember.DtdMembersId = Guid.NewGuid().ToString();
            dtdMember.DtdUserName = "TungDuong";
            dtdMember.DtdPassword = "123456";
            dtdMember.DtdFullName = "Do Tung Duong";
            dtdMember.DtdEmail = "atgdotungduong@gmail.com";
            return View(dtdMember);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
