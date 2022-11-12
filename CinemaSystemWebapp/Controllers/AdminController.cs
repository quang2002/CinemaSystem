using CinemaSystemWebapp.Models;
using CinemaSystemWebapp.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CinemaSystemWebapp.Controllers
{
    public class AdminController : Controller
    {
        public CinemaSystemContext dbcontext { get; set; } = new();

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
            dbcontext.Dispose();
        }

        public Models.User AdminUser { get; set; } = null!;

        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var user = Authentication.GetUserByCookies(context.HttpContext.Request.Cookies);

            if (user is null || user.Role != (int)Models.User.Roles.Admin)
            {
                context.Result = new RedirectResult("/");
            }

            AdminUser = user!;
        }

        public IActionResult Index(string? tab)
        {
            ViewBag.Categories = dbcontext.Categories.ToList();
            ViewBag.Films = dbcontext.Films.ToList();

            ViewBag.ActiveTab = tab;

            return View(AdminUser);
        }

        [HttpPost]
        public IActionResult CreateShow(int id, float price, DateTime start, int room)
        {
            var film = dbcontext.Films.Find(id);
            var roomObj = dbcontext.Rooms.Find(room);

            if (film is null || roomObj is null)
            {
                return RedirectToAction("Index", "Film", new { id = id, message = "Invalid film or room!" });
            }

            var show = new Show
            {
                FilmId = film.Id,
                RoomId = roomObj.Id,
                Start = start,
                End = start.AddMinutes(film.Length),
                TicketPrice = price
            };

            if (dbcontext.Shows.Any(s => s.RoomId == show.RoomId && ((s.End > show.Start && s.End < show.End) || (s.Start > show.Start && s.Start < show.End) || (s.Start < show.Start && s.End > show.End))))
            {
                return RedirectToAction("Index", "Film", new { id = id, message = "Show time is not valid!" });
            }

            dbcontext.Shows.Add(show);
            dbcontext.SaveChanges();

            return RedirectToAction("Index", "Film", new { id = id, message = "Create show successful!" });
        }

        [HttpPost]
        public IActionResult Category(int? id, string name, string description, string action)
        {
            switch (action)
            {
                case "create":
                    dbcontext.Categories.Add(new Models.Category() { Name = name, Desc = description });
                    dbcontext.SaveChanges();
                    break;
                case "edit":
                    if (id.HasValue)
                    {
                        dbcontext.Categories.Update(new Models.Category() { Id = id.Value, Name = name, Desc = description });
                        dbcontext.SaveChanges();
                    }
                    break;
                case "delete":
                    if (id.HasValue)
                    {
                        dbcontext.Categories.Remove(new Models.Category() { Id = id.Value });
                        dbcontext.SaveChanges();
                    }
                    break;
                default:
                    break;
            }

            return RedirectToAction(nameof(Index), new { tab = "category" });
        }

        [HttpPost]
        public IActionResult Film(int? id, string name, string description, List<int>? categories, [FromForm(Name = "release-date")] DateTime? releaseDate, int? length, string action, IFormFile? image)
        {
            switch (action)
            {
                case "create":
                    if (image is not null)
                    {
                        var uploadPath = Path.Combine(Path.GetFullPath("wwwroot"), "assets");
                        using (var stream = image.OpenReadStream())
                        {
                            string filepath = $"/assets/{UploadFile.Upload(uploadPath, image.FileName, stream).FileName}";

                            dbcontext.Films.Add(new Models.Film()
                            {
                                Name = name,
                                Desc = description,
                                Categories = dbcontext.Categories.Where(e => categories!.Contains(e.Id)).ToList(),
                                ReleaseDate = releaseDate!.Value,
                                Length = length!.Value,
                                ImageUrl = filepath
                            });

                            dbcontext.SaveChanges();
                        }
                    }
                    break;
                case "delete":
                    if (id.HasValue)
                    {
                        dbcontext.Films.Remove(new Models.Film() { Id = id.Value });
                        dbcontext.SaveChanges();
                    }
                    break;
                default:
                    break;
            }

            return RedirectToAction(nameof(Index), new { tab = "film" });
        }
    }
}
