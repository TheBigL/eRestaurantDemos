using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Bill
    {
        [Key]
        public int BillID { get; set; }
        [Required]
        public DateTime BillDate { get; set; }
        [Required]
        public DateTime OrderPlaced { get; set; }
        [Required]
        public DateTime OrderReady { get; set; }
        [Required]
        public DateTime OrderServed { get; set; }
        [Required]
        public DateTime OrderPaid { get; set; }
        [Required]
        public int NumberInParty { get; set; }
        [Required]
        public bool PaidStatus { get; set; }
        [ForeignKey("WaiterID")]
        public int WaiterID { get; set; }
        [ForeignKey("TableID")]
        public int TableID { get; set; }
        [ForeignKey("ReservationID")]
        public int ReservationID { get; set; }

        public string Comment { get; set; }

        public virtual Waiter Waiter { get; set; }
        public virtual Reservation Reservation { get; set; }
        public virtual Table Table { get; set; }
    }
}
