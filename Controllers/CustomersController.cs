using System;
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

        public ActionResult New()
        {
            List<MembershipTypes> membershipTypesList = new List<MembershipTypes>()
            {
                new MembershipTypes() { Name = "1", Id = 1},
                new MembershipTypes() { Name = "2", Id = 2}
            };
            var viewModel = new CustomerFormViewModel()
            {
                MembershipTypes = membershipTypesList
            };
            return View(viewModel);
        }
        
        [HttpPost]
        public ActionResult Create(CustomerFormViewModel customerFormViewModel)
        {
            var viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer() { Name = "Jan", Id = 1 },
                MembershipTypes = new List<MembershipTypes>()
                {
                    new MembershipTypes() { Name = "Kappa", Id = 1}
                }
            };
            if (!ModelState.IsValid)
            {
                return View("New", viewModel);
            }
            Console.Write(customerFormViewModel.Customer.Name + customerFormViewModel.Customer.MembershipTypesId);
            return RedirectToAction("Index", "Customers");
        }

        public ActionResult Edit(int id)
        {
            var viewModel = new CustomerFormViewModel()
            {
                Customer = new Customer() { Name = "Jan", Id = 1 },
                MembershipTypes = new List<MembershipTypes>()
                {
                    new MembershipTypes() { Name = "Kappa", Id = 1}
                }
            };
            return View("New", viewModel);
        }
    }
}