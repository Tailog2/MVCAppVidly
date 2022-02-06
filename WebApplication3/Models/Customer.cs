using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace WebApplication3.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; } = null!;

        public bool IsSubscribedToNewsletter { get; set; }

        [Display(Name = "Membership Type")]
        [Required]
        public byte MembershipTypeId { get; set; }

        public MembershipType MembershipType { get; set; } = null!;

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:yyyy/MM/dd}", ApplyFormatInEditMode = true)]
        public DateTime? BirthDate { get; set; } = null;
    }
}
