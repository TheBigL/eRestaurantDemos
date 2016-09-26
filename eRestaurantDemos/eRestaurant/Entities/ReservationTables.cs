using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class ReservationTables
    {
        public int TableID { get; set; }
        public int ReservationID { get; set; }

        public virtual Table Table { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
