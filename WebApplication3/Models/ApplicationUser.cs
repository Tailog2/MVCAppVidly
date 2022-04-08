using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class ApplicationUser : IdentityUser
    {
        [Required]
        [StringLength(255)]
        public string PassportId { get; set; } = null!;
    }
}
