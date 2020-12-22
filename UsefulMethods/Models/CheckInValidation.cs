using System;
using System.ComponentModel.DataAnnotations;

namespace UsefulMethods.Models
{
    public class CheckInValidation : ValidationAttribute
    {
        private readonly string _comparisonProperty;
        public CheckInValidation(string comparisonProperty)
        {
            _comparisonProperty = comparisonProperty;
        }
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            ErrorMessage = ErrorMessageString;

            var property = validationContext.ObjectType.GetProperty(_comparisonProperty);
            if (property == null)
                throw new ArgumentException("Property with this name not found");

            var currentValue = (DateTime)value;
            var comparisonValue = (DateTime)property.GetValue(validationContext.ObjectInstance);

            if (currentValue > comparisonValue)
                return new ValidationResult(ErrorMessage);

            return ValidationResult.Success;

        }
    }
}
