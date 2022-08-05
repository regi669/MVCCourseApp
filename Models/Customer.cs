using System.ComponentModel.DataAnnotations;

namespace MVCCourseApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        
        [Required]
        [StringLength(20)]
        [Display(Name = "Customer Name")]
        public string Name { get; set; }

        [Display(Name = "Membership")]
        public int MembershipTypesId { get; set; }
    }
}