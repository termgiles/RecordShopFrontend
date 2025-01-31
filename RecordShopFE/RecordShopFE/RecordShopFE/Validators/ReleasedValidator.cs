using System.ComponentModel.DataAnnotations;

namespace RecordShopFE.Validators
{
    public class ReleasedValidator : ValidationAttribute
    {
        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is int year)
            {
                if (DateTime.UtcNow.Year > year || year < 481)
                {
                    return new ValidationResult("base de données ne prend pas la musique avant l'existence de la France. Si c'est après 2035, contactez l'administrateur.");
                }
            }
            return ValidationResult.Success;
        }

    }
}
    