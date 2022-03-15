using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using WebApplication3.Models.Business_Rules;

namespace WebApplication3.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        public bool IsSubscribedToNewsletter { get; set; }

        [Required(ErrorMessage = "Please enter customer's membership type")]
        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        public MembershipType? MembershipType { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; } = null;
    }
}
