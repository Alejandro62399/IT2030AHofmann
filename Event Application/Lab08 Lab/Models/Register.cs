using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab08_Lab.Models
{
    public class Register
    {
        [Required]
        public virtual string EventTitle { get; set; }

        [Required]
        public virtual int NumberofTickets { get; set; }

    }
}