using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class ReservationTables
    {
        [Key]
        public int TableID { get; set; }
        [Required]
        public int ReservationID { get; set; }

        public virtual Table Table { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
