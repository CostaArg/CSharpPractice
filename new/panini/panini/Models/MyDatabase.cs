using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace panini.Models
{
    public class MyDatabase : DbContext
    {
        public MyDatabase() : base("Paninia")
        {

        }
        public DbSet<Sandwich> Sandwiches { get; set; }
    }
}