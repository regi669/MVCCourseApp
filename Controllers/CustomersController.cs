using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MVCCourseApp.Models;
using MVCCourseApp.ViewModels;

namespace MVCCourseApp.Controllers
{
    public class CustomersController : Controller
    {
        List<Customer> customers = new List<Customer>()
        {
            new Customer() { Name = "Jan", Id = 1},
            new Customer() { Name = "Ban", Id = 2}
        };
        public ActionResult Index()
        {
            var viewModel = new RandomMovieViewModel()
            {
                Customers = customers
            };
            return View(viewModel);
        }

        public ActionResult Detail(int id)
        {
            var customer =  customers.FirstOrDefault(c => c.Id == id);
            return Content(customer?.Name);
        }
    }
}