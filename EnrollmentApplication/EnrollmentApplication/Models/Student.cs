using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EnrollmentApplication.Models
{
    public class Student
    {
        public virtual int StudentId { get; set; }
        [Required]
        [StringLength(50)]
        public virtual int StudentFirstName { get; set; }
        [Required]
        [StringLength(50)]
        public virtual int StudentLastName { get; set; }
     

    }
}