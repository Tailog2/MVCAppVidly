using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class MembershipType
    {
        [Key]
        public byte Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;
        public short SingUpFee { get; set; }
        public byte DurationInMonths { get; set; }
        public byte DiscountRate { get; set; }

        public enum MembershipTypeName
        {
            PayAsYouGo = 1,
            Monthly = 2,
            Quarterly = 3,
            Annually = 4
        }
    }
}
