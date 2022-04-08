using System.ComponentModel.DataAnnotations;

namespace WebApplication3.DataTransferObjects
{
    public class MembershipTypeDto
    {
        [Key]
        public byte Id { get; set; }

        [Required]
        [StringLength(20)]
        public string Name { get; set; } = null!;
    }
}
