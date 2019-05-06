using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab08_Lab.Models
{
    public class LastMinuteDeals
    {
        [Required]
        [StringLength(50)]
        public virtual string EventTitle { get; set; }


        [Required]
        public virtual DateTime EventStartDate { get; set; }

        [Required]
        public virtual DateTime EventStartTime { get; set; }


        [Required]
        public virtual string EventLocation { get; set; }

    }
}