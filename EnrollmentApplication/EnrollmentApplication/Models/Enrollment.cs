using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Enrollment
    {
        public virtual int EnrollmentId { get; set; }
        public virtual int StudentId { get; set; }
        public virtual int CourseId { get; set; }
        [Required]
        [RegularExpression(@"^[a-fA-F]*$")]
        public virtual string Grade { get; set; }
        public virtual int StudentObject { get; set; }
        public virtual int CourseObject { get; set; }
        public virtual Boolean IsActive { get; set; }
        [Required]
        public virtual String AssignedCampus { get; set; }
        [Required]
        public virtual String EnrollmentSemester { get; set; }
        [Required]
        [RegularExpression(@"^[0-2018]*$")]
        public virtual int EnrollmentYear { get; set; }

        [InvalidChars(50)]
        public virtual string Notes { get; set; }
        

       
        
    }
}