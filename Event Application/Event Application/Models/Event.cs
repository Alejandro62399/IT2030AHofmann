using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Lab08_Lab.Models
{
    public class Event
    {
        [Required]
        [StringLength(50)]
        public virtual string EventTitle { get; set; }

        [StringLength(150)]
        public virtual string Description { get; set; }

        [Required]
        public virtual DateTime EventStartDate { get; set; }

        [Required]
        public virtual DateTime EventStartTime { get; set; }

        [Required]
        public virtual DateTime EventEndDate { get; set; }

        [Required]
        public virtual DateTime EventEndTime { get; set; }

        [Required]
        public virtual string EventLocation { get; set; }


        public virtual string EventType { get; set; }

        [Required]
        public virtual string OrganizerName { get; set; }


        public virtual string OrganizerContactInfo { get; set; }

        [Required]
        public virtual int MaxTickets { get; set; }

        [Required]
        public virtual int AvailableTickets { get; set; }
    }
}