using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TripLog.Models
{
    public class Trip
    {
        public int TripId { get; set; }

        [Required(ErrorMessage = "Please select Destination.")]
        public string Destination { get; set; }

        [Required(ErrorMessage = "Please select trip start date.")]
        public DateTime StartDate { get; set; }

        [Required(ErrorMessage = "Please select trip end date.")]
        public DateTime EndDate { get; set; }

        public string Accomodation { get; set; }

        public string AccomodationPhone { get; set; }

        public string AccomodationEmail { get; set; }

        public string ThingsToDo1 { get; set; }

        public string ThingsToDo2 { get; set; }

        public string ThingsToDo3 { get; set; }
    }
}
