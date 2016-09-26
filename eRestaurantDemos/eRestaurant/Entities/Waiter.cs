using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Waiter
    {
        [Key]
        public int WaiterID { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Phone { get; set; }
        public string Address { get; set; }
        public DateTime HireDate { get; set; }
        public DateTime ReleaseDate { get; set; }

    }
}
