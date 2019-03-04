using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class InvalidCharsAttribute : ValidationAttribute
    {
        readonly int Notes;

        public InvalidCharsAttribute(int Notes)
        {
            this.Notes = Notes;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if ((int)value < Notes)
                {
                    return new ValidationResult("Notes contains unacceptable characters");
                }
            }
            return ValidationResult.Success;
        }
    }
}



  