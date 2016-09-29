using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Items
    {
        [Key]
        public int ItemID { get; set; }
        [Required]
        [StringLength(35)]
        public string Description { get; set; }
        [Required]
        public double CurrentPrice { get; set; }
        [Required]
        public double CurrentCost { get; set; }
        [Required]
        public bool Active { get; set; }
        public int Calories { get; set; }
        public string Comment { get; set; }
        [Required]
        public int MenuCategoryID { get; set; }

        public virtual MenuCategories MenuCategories { get; set; }

    }
}
