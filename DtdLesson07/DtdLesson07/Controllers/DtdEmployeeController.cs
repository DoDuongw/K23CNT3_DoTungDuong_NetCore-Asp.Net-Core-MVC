using DtdLesson07.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DtdLesson07.Controllers
{
    public class DtdEmployeeController : Controller
    {
        // GET: DtdEmployeeController
     //MOCK DATA
     private static List<DtdEmployee> dtdListEmployee = new List<DtdEmployee>()
        {
            new DtdEmployee
            {
                DtdId = 231090027,
                DtdName = "Đỗ Tùng Dương",
                DtdBirthday = new DateTime(2005, 4, 16),
                DtdEmail = "atgdotungduong@gmail.com",
                DtdPhone = "0375526086",
                DtdSalary = 12000000,
                DtdStatus = true
            },
            new DtdEmployee
            {
                DtdId = 2,
                DtdName = "Trần Thị B",
                DtdBirthday = new DateTime(1997, 8, 20),
                DtdEmail = "b.tran@example.com",
                DtdPhone = "0912345678",
                DtdSalary = 10500000,
                DtdStatus = false
            },
            new DtdEmployee
            {
                DtdId = 3,
                DtdName = "Lê Văn C",
                DtdBirthday = new DateTime(1993, 3, 2),
                DtdEmail = "c.le@example.com",
                DtdPhone = "0909090909",
                DtdSalary = 13500000,
                DtdStatus = true
            }
        };
        
        public ActionResult DtdIndex()
        {
            return View(dtdListEmployee);
        }

        // GET: DtdEmployeeController/DtdDetails/5
        public ActionResult DtdDetails(int id)
        {
            var dtdEmployee = dtdListEmployee.FirstOrDefault(x => x.DtdId == id);

            return View(dtdEmployee);
        }

        // GET: DtdEmployeeController/DtdCreate
        public ActionResult DtdCreate()
        {
            var dtdEmoloyee = new DtdEmployee();
            return View(dtdEmoloyee);
        }

        // POST: DtdEmployeeController/DtdCreate
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtdCreate(DtdEmployee dtdModel)
        {
            try
            {
                dtdModel.DtdId = dtdListEmployee.Max(x => x.DtdId) + 1;
                dtdListEmployee.Add(dtdModel);
                return RedirectToAction(nameof(DtdIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: DtdEmployeeController/DtdEdit/5
        public ActionResult DtdEdit(int id)
        {
            var dtdEmployee = dtdListEmployee.FirstOrDefault(x => x.DtdId == id);
            return View(dtdEmployee);
        }

        // POST: DtdEmployeeController/DtdEdit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult DtdEdit(int id, DtdEmployee dtdModel)
        {
            try
            {
                for (int i = 0; i < dtdListEmployee.Count(); i++) { 
                    if (dtdListEmployee[i].DtdId == id)
                    {
                        dtdListEmployee[i] = dtdModel;
                        break;
                    }
            }
                return RedirectToAction(nameof(DtdIndex));
            }
            catch
            {
                return View();
            }
        }

        // GET: DtdEmployeeController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: DtdEmployeeController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
