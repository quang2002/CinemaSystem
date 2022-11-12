using CinemaSystemWebapp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaSystemWebapp.Controllers
{
    public class FilmController : Controller
    {
        public CinemaSystemContext dbcontext { get; set; } = new();

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            dbcontext.Dispose();
        }

        public IActionResult Index(int id, string? message)
        {
            ViewBag.Message = message;
            ViewBag.Rooms = dbcontext.Rooms.ToList();
            return View(
                dbcontext.Films
                .Include(e => e.Categories)
                .Include(e => e.Shows)
                .ThenInclude(e => e.Room)
                .FirstOrDefault(e => e.Id == id)
            );
        }
    }
}
