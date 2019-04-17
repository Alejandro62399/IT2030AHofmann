using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student :IValidatableObject
    {
        public virtual int StudentId { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string StudentFirstName { get; set; }
        [Required]
        [StringLength(50)]
        public virtual string StudentLastName { get; set; }

        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        [StringLength(5, ErrorMessage = "Enter a 5 digit zipcode")]
        public string Zipcode { get; set; }
        [StringLength(2, ErrorMessage = "Enter a 2 digit state code")]
        public string State { get; set; }

        
        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {

            //if (Address2 String.Equals 1234

            {
                yield return (new ValidationResult("Address2 cannot be the same as Address1"));
            }

           //if(Zipcode < 10000 || Zipcode < 99999)
            {
                yield return (new ValidationResult("Enter a 5 digit zipcode"));
            }

            //if(State StringLength > 2 || State Stringlength < 2)
            // yield return (new ValidationResult("Enter a 2 digit state code"));


            
        }
    }
}