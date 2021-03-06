﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eRestaurant.Entities
{
    public class Table
    {

        [Key]
        public int TableID { get; set; }
        public int TableNumber { get; set; }
        public bool Smoking {get;set;}
        public int Capacity { get; set; }
        public bool Available { get; set; }


        public virtual ICollection<ReservationTables> ReservationTables { get; set; }
    }
}
