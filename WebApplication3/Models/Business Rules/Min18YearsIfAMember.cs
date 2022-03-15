using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models.Business_Rules
{
    public class Min18YearsIfAMember : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            var customer = (Customer) validationContext.ObjectInstance;
            if (customer.MembershipTypeId == MembershipType.Unknown || customer.MembershipTypeId == MembershipType.PayAsYouGo)
            {
                return ValidationResult.Success;
            }

            if (customer.BirthDate == null)
            {
                return new ValidationResult("Birthdate is required for this type of membership");
            }

            var age = DateTime.Today.Year - customer.BirthDate.Value.Year;
            return age >= 18
                ? ValidationResult.Success
                : new ValidationResult("A customer should be at list 18 years old for this type of membership");
        }
    }
}
