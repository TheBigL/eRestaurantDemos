using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class BillItems
    {
        public int BillID { get; set; }
        public int ItemID { get; set; }
        public int Quantity { get; set; }
        public decimal SalePrice { get; set; }
        public decimal UnitCost { get; set; }
        public string Notes { get; set; }
        public int TableNumber { get; set; }
        public int SeatNumber { get; set; }
        public int QtyServed { get; set; }

        public virtual Bill Bill { get; set; }
        public virtual Items Items { get; set; }
    }
}
