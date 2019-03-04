using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Course
    {
        public virtual int CourseId { get; set; }
        [Required]
        [StringLength(150)]
        public virtual int CourseTitle { get; set; }
        public virtual int CourseDescription { get; set; }
        [Required]
        [Range(1, 4)] public int NumCredits { get; set; }
        public virtual int CourseCredits { get; set; }

    }
}