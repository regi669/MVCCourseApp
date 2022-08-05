using System.Web.Mvc;
using MVCCourseApp.Models;

namespace MVCCourseApp.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "CAT IN BOOTS" };
            return View(movie);
        }
    }
}