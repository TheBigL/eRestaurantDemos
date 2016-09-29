using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class RecipeIngredients
    {
       [Key]
       public int RecipeIngredientIF { get; set; }
       [ForeignKey("RecipeID")]
       public int RecipeID { get; set; }
       public string Description { get; set; }
       public string Quantity { get; set; }

       public virtual Recipes Recipes { get; set; }

    }
}
