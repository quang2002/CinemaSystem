using CinemaSystemWebapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaSystemWebapp.Controllers
{
    public class CategoryController : Controller
    {

        public CinemaSystemContext dbcontext { get; set; } = new();

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            dbcontext.Dispose();
        }

        public IActionResult Index(int id)
        {
            return View(dbcontext.Categories.Include(e => e.Films).FirstOrDefault(e => e.Id == id));
        }
    }
}
