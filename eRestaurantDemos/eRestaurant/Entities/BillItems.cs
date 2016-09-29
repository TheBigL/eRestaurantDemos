using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class BillItems
    {
        [Key]
        public int BillID { get; set; }
        [Required]
        public int ItemID { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal SalePrice { get; set; }
        [Required]
        public decimal UnitCost { get; set; }
        [Required]
        public string Notes { get; set; }
        [Required]
        public int TableNumber { get; set; }
        [Required]
        public int SeatNumber { get; set; }
        [Required]
        public int QtyServed { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Items Items { get; set; }
    }
}
