using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab08_Lab.Models
{
    public class Order
    {
        [Required]
        public virtual int OrderId { get; set; }

        [Required]
        public virtual string EventTitle { get; set; }

        [Required]
        public virtual int NumberOfTickets { get; set; }

        [Required]
        public virtual DateTime DateOrdered { get; set; }

        [Required]
        public virtual string EventDescription { get; set; }

        [Required]
        public virtual DateTime EventStartTime { get; set; }

        [Required]
        public virtual DateTime EventEndTime { get; set; }


    }
}