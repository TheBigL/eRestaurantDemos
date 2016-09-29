using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Recipes
    {
        [Key]
        public int RecipeID { get; set; }
        public string Instructions { get; set; }
        public int PrepTime { get; set; }
        public int ItemID { get; set; }

    }
}
