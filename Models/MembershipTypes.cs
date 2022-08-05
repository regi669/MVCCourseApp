using System.ComponentModel.DataAnnotations;

namespace MVCCourseApp.Models
{
    public class MembershipTypes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public short SignUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }
    }
}