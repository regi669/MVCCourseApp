using System.Collections.Generic;
using System.Web.Mvc;
using MVCCourseApp.Models;
using MVCCourseApp.ViewModels;

namespace MVCCourseApp.Controllers
{
    public class MoviesController : Controller
    {
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "CAT IN BOOTS" };
            var customers = new List<Customer>()
            {
                new Customer() { Name = "Jan"},
                new Customer() { Name = "Ban"}
            };
            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers,
                Movie = movie
            };
            return View(viewModel);
        }

        public ActionResult Edit(int id)
        {
            return Content("id=" + id);
        }

        public ActionResult Index(int? pageIndex, string sortBy)
        {
            if (!pageIndex.HasValue)
                pageIndex = 1;
            if (string.IsNullOrWhiteSpace(sortBy))
                sortBy = "Name";
            return Content($"pageIndex={pageIndex}&sortBy={sortBy}");
        }

        [Route("movies/released/{year}/{month:regex(\\d{2}):range(1, 12)}")]
        public ActionResult ByReleaseDate (int year, int month)
        {
            return Content(year + "/" + month);
        }
    }
}