using System.Collections;
using System.ComponentModel.DataAnnotations;

namespace RhythmFlow.Application.src.DTOs.ValidationAttributes
{
    [AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false)]
    public class NoEmptyGuidAttribute : ValidationAttribute
    {
        public bool ValidateCollection { get; set; } = false;

        protected override ValidationResult IsValid(object? value, ValidationContext validationContext)
        {
            if (value is Guid guidValue)
            {
                // Check if single GUID is empty
                if (guidValue == Guid.Empty)
                {
                    return new ValidationResult("Guid cannot be empty.");
                }
            }
            else if (ValidateCollection && value is IEnumerable<Guid> guidCollection && guidCollection.Any(guid => guid == Guid.Empty))
            {
                return new ValidationResult("Collection contains an empty Guid.");
            }

            return ValidationResult.Success!;
        }
    }
}