using lab10.Models;
using System;
using System.ComponentModel.DataAnnotations;

public class FutureDateAttribute : ValidationAttribute
{
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        var model = (Consultation)validationContext.ObjectInstance;

        // Check if the date is in the future
        if (value is DateTime dateTime)
        {
            if (dateTime.Date <= DateTime.Now.Date)
            {
                return new ValidationResult(ErrorMessage ?? "Дата повинна бути в майбутньому.");
            }

            // Check if the product is "Основи" and the date is a Monday
            if (model.Product == "Основи" && dateTime.DayOfWeek == DayOfWeek.Monday)
            {
                return new ValidationResult("Консультація з продукту «Основи» не може проходити по понеділках.");
            }
        }

        return ValidationResult.Success;
    }
}
