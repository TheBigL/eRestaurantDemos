using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace eRestaurant.DAL
{
    //: DbContext means that 
    internal class eRestaurantContext : DbContext
    {
        //: base(string) is the constructor of the DbContext class that I call before running the body of my own constructor.
        //Hooking up constructors to call other constructors is called "Constructor Chaining".
        public eRestaurantContext() : base("name=EatIn") { }


        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<SpecialEvent> SpecialEvents { get; set; }




    }
}
