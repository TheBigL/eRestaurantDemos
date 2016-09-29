using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class RecipeIngredients
    {
       [Key]
       public int RecipeIngredientIF { get; set; }
       public int RecipeID { get; set; }
       public string Description { get; set; }
       public string Quantity { get; set; }

       public virtual Recipes Recipes { get; set; }

    }
}
