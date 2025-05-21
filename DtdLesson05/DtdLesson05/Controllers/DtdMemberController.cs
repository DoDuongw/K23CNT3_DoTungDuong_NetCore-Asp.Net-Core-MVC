using DtdLesson05.Models.DataModels;
using Microsoft.AspNetCore.Mvc;

namespace DtdLesson05.Controllers
{
    public class DtdMemberController : Controller
    {
        public static List<DtdMember> dtdListMember = new List<DtdMember>()
        {
              new DtdMember
            {
                DtdMembersId = "2310900027",
                DtdUserName = " Duong",
                DtdPassword = "123456",
                DtdFullName = "Do Tung Duong",
                DtdEmail = "atgdotungduong@gmail.com"
            },
            new DtdMember
            {
                DtdMembersId = "MB002",
                DtdUserName = "jane_smith",
                DtdPassword = "pass456",
                DtdFullName = "Jane Smith",
                DtdEmail = "jane.smith@gmail.com"
            },
            new DtdMember
            {
                DtdMembersId = "MB003",
                DtdUserName = "alice_walker",
                DtdPassword = "alice@789",
                DtdFullName = "Alice Walker",
                DtdEmail = "alice.walker@gmail.com"
            },
            new DtdMember
            {
                DtdMembersId = "MB004",
                DtdUserName = "bob_martin",
                DtdPassword = "bobPass",
                DtdFullName = "Bob Martin",
                DtdEmail = "bob.martin@gmail.com"
            },
            new DtdMember
            {
                DtdMembersId = "MB005",
                DtdUserName = "emma_nguyen",
                DtdPassword = "emmaSecure!",
                DtdFullName = "Emma Nguyen",
                DtdEmail = "emma.nguyen@gmail.com"
            }
        };
        public IActionResult DtdIndex()
        {
            return View(dtdListMember);
        }
    }
}
