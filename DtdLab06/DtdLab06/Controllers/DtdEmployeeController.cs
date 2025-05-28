using DtdLab06.Models;
using Microsoft.AspNetCore.Mvc;

namespace DtdLab06.Controllers
{
    public class DtdEmployeeController : Controller
    {
        private static List<DtdEmployee> DtdListEmployee = new List<DtdEmployee>
    {
        new DtdEmployee { DtdId = 1, DtdName = "Đỗ Tùng Dương", DtdBirthDay = new DateTime(2005, 4, 16), DtdEmail = "Dtddotungduong@gmail.com", DtdPhone = "0375526086", DtdSalary = 10002, DtdStatus = true },
        new DtdEmployee { DtdId = 2, DtdName = "Tran Thi B", DtdBirthDay = new DateTime(1992, 2, 2), DtdEmail = "b@gmail.com", DtdPhone = "0902222222", DtdSalary = 1200, DtdStatus = true },
        new DtdEmployee { DtdId = 3, DtdName = "Le Van C", DtdBirthDay = new DateTime(1988, 3, 3), DtdEmail = "c@gmail.com", DtdPhone = "0903333333", DtdSalary = 1100, DtdStatus = false },
        new DtdEmployee { DtdId = 4, DtdName = "Pham Thi D", DtdBirthDay = new DateTime(1995, 4, 4), DtdEmail = "d@gmail.com", DtdPhone = "0904444444", DtdSalary = 1300, DtdStatus = true },
        new DtdEmployee { DtdId = 5, DtdName = "Do Tung Duong", DtdBirthDay = new DateTime(2005, 4, 16), DtdEmail = "duong@gmail.com", DtdPhone = "0375526086", DtdSalary = 500, DtdStatus = true } // Sinh viên
    };
        public IActionResult DtdIndex()
        {
            return View(DtdListEmployee);
        }
        // Hiển thị form thêm mới
        [HttpGet]
        public IActionResult DtdCreate()
        {
            return View();
        }

        // Xử lý thêm mới nhân viên
        [HttpPost]
        public IActionResult DtdCreateSubmit(DtdEmployee emp)
        {
            emp.DtdId = DtdListEmployee.Max(e => e.DtdId) + 1;
            DtdListEmployee.Add(emp);
            return RedirectToAction("DtdIndex");
        }

        // Hiển thị form chỉnh sửa
        [HttpGet]
        public IActionResult DtdEdit(int id)
        {
            var emp = DtdListEmployee.FirstOrDefault(e => e.DtdId == id);
            return View(emp);
        }

        // Xử lý cập nhật thông tin
        [HttpPost]
        public IActionResult DtdEditPUT(DtdEmployee emp)
        {
            var old = DtdListEmployee.FirstOrDefault(e => e.DtdId == emp.DtdId);
            if (old != null)
            {
                old.DtdName = emp.DtdName;
                old.DtdBirthDay = emp.DtdBirthDay;
                old.DtdEmail = emp.DtdEmail;
                old.DtdPhone = emp.DtdPhone;
                old.DtdSalary = emp.DtdSalary;
                old.DtdStatus = emp.DtdStatus;
            }
            return RedirectToAction("DtdIndex");
        }

        // Xóa nhân viên
        public IActionResult DtdDelete(int id)
        {
            var emp = DtdListEmployee.FirstOrDefault(e => e.DtdId == id);
            if (emp != null)
            {
                DtdListEmployee.Remove(emp);
            }
            return RedirectToAction("DtdIndex");
        }
    }
}
