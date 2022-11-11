using CinemaSystemWebapp.Models;
using CinemaSystemWebapp.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CinemaSystemWebapp.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Setting()
        {
            var user = Authentication.GetUserByCookies(Request.Cookies);

            if (user is null)
                return RedirectToAction("Signin", "Home");

            return View(user);
        }

        public IActionResult Tickets()
        {
            var user = Authentication.GetUserByCookies(Request.Cookies);

            if (user is null)
                return RedirectToAction("Signin", "Home");

            using var db = new CinemaSystemContext();

            return View(db.Tickets
                .Include(e => e.Show)
                .ThenInclude(e => e.Film)
                .Include(e => e.Show)
                .ThenInclude(e => e.Room)
                .ToList()
                .Where(e => e.UserId == user.Id)
                .GroupBy(e => e.Show)
                .ToList()
            );
        }

        [HttpPost]
        public IActionResult ChangeInfo(string name, string email, IFormFile avatar)
        {
            var user = Authentication.GetUserByCookies(Request.Cookies);

            if (user is null)
                return RedirectToAction("Signin", "Home");

            user.Name = name.Trim();
            user.Email = email.Trim();

            if (avatar is not null)
            {
                var uploadPath = Path.Combine(Path.GetFullPath("wwwroot"), "assets");
                using (var stream = avatar.OpenReadStream())
                    user.AvatarUrl = $"/assets/{UploadFile.Upload(uploadPath, avatar.FileName, stream).FileName}";
            }

            using CinemaSystemContext dbcontext = new();
            dbcontext.Users.Update(user);
            dbcontext.SaveChanges();

            return RedirectToAction(nameof(Setting));
        }

        [HttpPost]
        public IActionResult ChangePassword([FromForm(Name = "old-password")] string oldPassword, [FromForm(Name = "new-password")] string newPassword)
        {
            var user = Authentication.GetUserByCookies(Request.Cookies);

            if (user is null)
                return RedirectToAction("Signin", "Home");

            if (user.Password != Crypto.SHA256(oldPassword))
                return RedirectToAction("Signout", "Home");

            user.Password = Crypto.SHA256(newPassword);

            using CinemaSystemContext dbcontext = new();
            dbcontext.Users.Update(user);
            dbcontext.SaveChanges();

            return RedirectToAction(nameof(Setting));
        }
    }
}
