using DtdLesson04.Models;
using Microsoft.AspNetCore.Mvc;
using static System.Net.WebRequestMethods;

namespace DtdLesson04.Controllers
{
    public class DtdBookController : Controller
    {
        private List     <DtdBook> dtdbooks = new List<DtdBook>
            {
                new DtdBook
                {
                    DtdId = "B001",
                    DtdTitle = "Lập Trình C# Cơ Bản",
                    DtdDescription = "Cuốn sách hướng dẫn lập trình C# từ cơ bản đến nâng cao.",
                    DtdImage = "https://images-na.ssl-images-amazon.com/images/I/51N-u8AsmdL._SX331_BO1,204,203,200_.jpg",
                    DtdPrice = "150000",
                    DtdPage = "320"
                },
                new DtdBook
                {
                    DtdId = "B002",
                    DtdTitle = "Học SQL Server",
                    DtdDescription = "Tìm hiểu cơ bản về cơ sở dữ liệu và SQL Server.",
                    DtdImage = "https://images-na.ssl-images-amazon.com/images/I/61Iz2yy2CKL.jpg",
                    DtdPrice = "130000",
                    DtdPage = "250"
                },
                new DtdBook
                {
                    DtdId = "B003",
                    DtdTitle = "ASP.NET Core Web API",
                    DtdDescription = "Xây dựng ứng dụng Web API với ASP.NET Core.",
                    DtdImage = "https://images-na.ssl-images-amazon.com/images/I/71UwSHSZRnS.jpg",
                    DtdPrice = "180000",
                    DtdPage = "290"
                },
                new DtdBook
                {
                    DtdId = "B004",
                    DtdTitle = "Kỹ Thuật Lập Trình Hướng Đối Tượng",
                    DtdDescription = "Lý thuyết và thực hành lập trình hướng đối tượng.",
                   DtdImage = "https://m.media-amazon.com/images/I/41as+WafrFL._SX331_BO1,204,203,200_.jpg",
                   DtdPrice = "160000",
                    DtdPage = "310"
                },
                new DtdBook
                {
                    DtdId = "B005",
                    DtdTitle = "Xây Dựng Website Với Laravel",
                    DtdDescription = "Hướng dẫn từng bước tạo website với Laravel Framework.",
                    DtdImage = "https://images-na.ssl-images-amazon.com/images/I/81eB+7+CkUL.jpg\r\n\r\n",
                    DtdPrice = "175000",
                    DtdPage = "340"
                }
            };

        //GET : /DtdBook/DtdIndex => Lay full sach
        public IActionResult DtdIndex()
        {
            //Dua du lieu tren view
            return View(dtdbooks);
        }
        //GET : /DtdBook/DtdCreate => Lay full sach

        public IActionResult DtdCreate()
        {
            DtdBook dtdBook = new DtdBook();
            return View(dtdBook);
        }
        //POST: /DtdBook/DtdCreateSubmit

        [HttpPost]
        public IActionResult DtdCreateSubmit(DtdBook newBook)
        {
            if (ModelState.IsValid)
            {
                // Add the new book to the list (or save it to your database)
                dtdbooks.Add(newBook);  // Assuming dtdbooks is your in-memory list

                return RedirectToAction("DtdIndex"); // Redirect to the book list page after submission
            }

            // If validation fails, return back to the form
            return View("DtdCreate", newBook);
        }

        //GET : /DtdBook/DtdEdit

        public IActionResult DtdEdit(string id)
        {
            return View();
        }
        [HttpPost]
        public IActionResult DtdEditSubmit(DtdBook book)
        {
            if (ModelState.IsValid)
            {
                var existingBook = dtdbooks.FirstOrDefault(b => b.DtdId == book.DtdId);
                if (existingBook != null)
                {
                    existingBook.DtdTitle = book.DtdTitle;
                    existingBook.DtdDescription = book.DtdDescription;
                    existingBook.DtdImage = book.DtdImage;
                    existingBook.DtdPrice = book.DtdPrice;
                    existingBook.DtdPage = book.DtdPage;
                }
                return RedirectToAction("DtdIndex");
            }

            return View("DtdEdit", book);
        }

        public IActionResult DtdDelete()
        {
            DtdBook dtdBook = new DtdBook();
            return View(dtdBook);
        }
        [HttpPost]
        public IActionResult DtdDeleteSubmit(string id)
        {
            var bookToRemove = dtdbooks.FirstOrDefault(b => b.DtdId == id);
            if (bookToRemove != null)
            {
                dtdbooks.Remove(bookToRemove);
            }
            return RedirectToAction("DtdIndex");
        }

    }
}
