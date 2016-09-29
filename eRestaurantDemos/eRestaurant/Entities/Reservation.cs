using eRestaurant.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant
{
    public class Reservation
    {
        [Key]
        public int ReservationID { get; set; }

        [Required]
        public string CustomerName { get; set; }

        [Range (1, 16)]
        public DateTime ReservationDate { get; set; }
        public int NumberInParty { get; set; }
        public string ContactPhone { get; set; }
        public string ReservationStatus { get; set; }
        [ForeignKey("EventCode")]
        public string EventCode { get; set; }


        
        public virtual SpecialEvent Event { get; set; }
        public virtual ICollection<ReservationTables> ReservationTables { get; set; }

    }
}
