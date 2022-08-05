using System.Collections.Generic;
using MVCCourseApp.Models;

namespace MVCCourseApp.ViewModels
{
    public class NewCustomerViewModel
    {
        public IEnumerable<MembershipTypes> MembershipTypes { get; set; }
        public Customer Customer { get; set; }
    }
}