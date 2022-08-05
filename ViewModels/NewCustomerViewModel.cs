using System.Collections.Generic;
using MVCCourseApp.Models;

namespace MVCCourseApp.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipTypes> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}