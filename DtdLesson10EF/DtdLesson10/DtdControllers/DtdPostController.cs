using DtdLesson10.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DtdLesson10.DtdControllers
{
    public class DtdPostController : Controller
    {
        private readonly DtdLesson10Context _context;

        public DtdPostController(DtdLesson10Context context)
        {
            _context = context;
        }

        public async Task<IActionResult> DtdIndex()
        {
            var posts = await _context.DtdPosts.ToListAsync();
            return View(posts);
        }
    }
}
