using System.ComponentModel.DataAnnotations;


namespace RhythmFlow.Application.src.DTOs.ValidationAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field, AllowMultiple = false)]
    public class FutureDateAttribute : ValidationAttribute
    {
        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is DateTime dateValue && dateValue < DateTime.Now)
            {
                return new ValidationResult("The date must be in the future.");
            }
            return ValidationResult.Success!;
        }
    }
}