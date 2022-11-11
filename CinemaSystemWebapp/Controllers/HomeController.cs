using CinemaSystemWebapp.Models;
using CinemaSystemWebapp.Utils;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
using System.Diagnostics;
using System.Net.Mail;

namespace CinemaSystemWebapp.Controllers
{
    public class HomeController : Controller
    {
        public CinemaSystemContext dbcontext { get; set; } = new();

        public HomeController()
        {
        }

        public IActionResult Index()
        {
            ViewBag.Films = dbcontext.Films.ToList();
            return View();
        }

        public IActionResult Search(string q)
        {
            q = q?.ToLower() ?? "";
            ViewBag.Films = dbcontext.Films.Where(e => e.Name.ToLower().Contains(q)).ToList();
            return View();
        }

        public IActionResult Signin()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signin(string email, string password)
        {
            string? token = Utils.Authentication.CreateToken(email, password, TimeSpan.FromDays(1));

            if (token is null)
            {
                return RedirectToAction(nameof(Signin));
            }

            Response.Cookies.Append("token", token);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Signup()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Signup(string email, string password, [FromForm(Name = "g-recaptcha-response")] string gRecatchaResponse)
        {
            if (!GRecaptcha.Verify(gRecatchaResponse))
            {
                return RedirectToAction(nameof(Signup));
            }

            User user = new()
            {
                Email = email,
                Password = Crypto.SHA256(password),
                Name = email,
                Role = ((int)Models.User.Roles.User),
                AvatarUrl = "/assets/default.jpg"
            };

            dbcontext.Users.Add(user);
            dbcontext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult ForgotPassword()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ForgotPassword(string email, [FromForm(Name = "g-recaptcha-response")] string gRecatchaResponse)
        {
            if (!GRecaptcha.Verify(gRecatchaResponse))
            {
                return RedirectToAction(nameof(ForgotPassword));
            }

            if (dbcontext.Users.FirstOrDefault(e => e.Email == email) is null)
            {
                return RedirectToAction(nameof(ForgotPassword));
            }

            string? token = Authentication.CreateToken(email, TimeSpan.FromMinutes(30));

            if (token is null)
            {
                return RedirectToAction(nameof(ForgotPassword));
            }

            string generatedLink = $"{Request.Host}/Home/{nameof(ResetPassword)}?token={token}";

            SMTP.Instance.Send("Reset Password", $"Here is your reset password link: {generatedLink}", email);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult ResetPassword(string token)
        {
            var user = Authentication.GetUserByToken(token);

            if (user is null)
            {
                throw new Exception("Token is invalid");
            }

            return View();
        }

        [HttpPost]
        public IActionResult ResetPassword(string password, string token)
        {
            var user = Authentication.GetUserByToken(token);

            if (user is null)
            {
                throw new Exception("Token is invalid");
            }

            user.Password = Crypto.SHA256(password);

            using CinemaSystemContext dbcontext = new();
            dbcontext.Users.Update(user);
            dbcontext.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Signout()
        {
            Response.Cookies.Delete("token");
            return RedirectToAction(nameof(Index));
        }

        public IActionResult Privacy()
        {
            return View();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            dbcontext.Dispose();
        }
    }
}