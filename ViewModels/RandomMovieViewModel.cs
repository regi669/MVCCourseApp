using System.Collections.Generic;
using MVCCourseApp.Models;

namespace MVCCourseApp.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}