using System.ComponentModel.DataAnnotations;
using WebApplication3.Models;

namespace WebApplication3.ViewModels
{
    public class CustomerFormViewModel
    {
        public Customer? Customer { get; set; } 
        public IEnumerable<MembershipType>? MembershipTypes { get; set; }
    }
}
