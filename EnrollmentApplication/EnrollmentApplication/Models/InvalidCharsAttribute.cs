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

        public InvalidCharsAttribute(int Notes) :base("{0} Notes contains unacceptable characters!")
        {
            this.Notes = Notes;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value != null)
            {
                if ((int)value < Notes)
                {
                    var errormessage = FormatErrorMessage(validationContext.DisplayName);

                    return new ValidationResult(errormessage);
                }
            }
            return ValidationResult.Success;
        }
    }
}



  