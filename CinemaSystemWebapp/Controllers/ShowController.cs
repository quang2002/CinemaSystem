using CinemaSystemWebapp.Models;
using CinemaSystemWebapp.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaSystemWebapp.Controllers
{
    public class ShowController : Controller
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

            return View(
                dbcontext.Shows
                .Include(e => e.Film)
                .Include(e => e.Room)
                .Include(e => e.Tickets)
                .FirstOrDefault(e => e.Id == id)
            );
        }

        [HttpPost]
        public IActionResult BuyTicket(int id, int row, int col)
        {
            var user = Authentication.GetUserByCookies(Request.Cookies);

            if (user is null)
                return RedirectToAction("Signin", "Home");

            var show = dbcontext.Shows
                .Include(e => e.Room)
                .Include(e => e.Tickets)
                .FirstOrDefault(e => e.Id == id);

            if (show is null || show.Room?.Rows < row || show.Room?.Cols < col)
                return RedirectToAction(nameof(Index), new { id = id, message = "Invalid show or wrong seat!" });

            if (show.Tickets.Any(e => e.Row == row && e.Col == col))
                return RedirectToAction(nameof(Index), new { id = id, message = "Sorry! Your seat has been ordered!" });

            if (show.TicketPrice > user.Balance)
                return RedirectToAction(nameof(Index), new { id = id, message = "Your balance is not enough!" });

            string GenOTP()
            {
                var rand = new Random();
                return new string(Enumerable.Range(0, 6).Select(_ => (char)rand.Next('0', '9' + 1)).ToArray());
            }

            Ticket ticket = new Ticket()
            {
                UserId = user.Id,
                ShowId = id,
                Row = row,
                Col = col,
                Otp = GenOTP()
            };

            dbcontext.Tickets.Add(ticket);
            dbcontext.SaveChanges();

            return RedirectToAction(nameof(Index), new { id = id, message = "Buy Ticket Success!" });
        }
    }
}
