using System;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace BetterBuiltWorkouts.Models
{
    public class NameAttribute : ValidationAttribute, IClientModelValidator
    {
        private int maxLength;
        public NameAttribute(int length)
        {
            maxLength = length;
        }

        protected override ValidationResult IsValid(object value, ValidationContext ctx)
        {
            if (value is string)
            {
                string name = (string)value;
                if (name.Length < maxLength)
                {
                    return ValidationResult.Success;
                }

            }
            return new ValidationResult(GetMsg(ctx.DisplayName));
        }

        public void AddValidation(ClientModelValidationContext ctx)
        {
            if (!ctx.Attributes.ContainsKey("data-val"))
                ctx.Attributes.Add("data-val", "true");
            ctx.Attributes.Add("data-val-name-length",
                maxLength.ToString());
            ctx.Attributes.Add("data-val-name",
                GetMsg(ctx.ModelMetadata.DisplayName ?? ctx.ModelMetadata.Name));
        }

        private string GetMsg(string name) => base.ErrorMessage ??
                $"{name} must be less than {maxLength} characters long.";
    }
}

