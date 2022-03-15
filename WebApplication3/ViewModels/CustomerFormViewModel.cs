using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication3.Models;
using WebApplication3.Models.Business_Rules;

namespace WebApplication3.ViewModels
{
    public class CustomerFormViewModel
    {
        [Key]
        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter customer's name")]
        [StringLength(255)]
        public string? Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        [Required(ErrorMessage = "Please enter customer's membership type")]
        [Display(Name = "Membership Type")]
        public byte? MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [Column(TypeName = "Date")]
        [DisplayFormat(DataFormatString = "{0:d MMM yyyy}", ApplyFormatInEditMode = true)]
        [Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; } = null;

        public IEnumerable<MembershipType>? MembershipTypes { get; set; }

        public string Title
        {
            get
            {
                return Id == 0 ? "New Customer" : "Edit Customer";
            }
        }

        public CustomerFormViewModel()
        {
            Id = 0;
        }

        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            IsSubscribedToNewsletter = customer.IsSubscribedToNewsletter;
            BirthDate = customer.BirthDate;
            MembershipTypeId = customer.MembershipTypeId;
        }
    }
}
