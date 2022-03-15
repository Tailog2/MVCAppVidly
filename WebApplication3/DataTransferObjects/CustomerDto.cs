using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebApplication3.Models.Business_Rules;

namespace WebApplication3.DataTransferObjects
{
    public class CustomerDto
    {
        [Key]
        public int Id { get; set; }

        [StringLength(255)]
        public string Name { get; set; } = null!;

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
        public MembershipTypeDto? MembershipType { get; set; }

        //[Min18YearsIfAMember]
        public DateTime? BirthDate { get; set; } = null;
    }
}
