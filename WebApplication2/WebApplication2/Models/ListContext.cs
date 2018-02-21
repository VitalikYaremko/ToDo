using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication2.Models
{
    public class ListContext : DbContext
    {
        public ListContext() :
           base("DefaultConnection")
        { }
        public DbSet<List> Lists { get; set; }
    }
}