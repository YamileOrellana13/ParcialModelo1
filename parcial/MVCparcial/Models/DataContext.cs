using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCparcial.Models
{
    public class DataContext:DbContext         //DbContex doy Ctrl .
    {
        public DataContext():base("DefaultConnection")        // doy ctor tab tab y me sale todo
        {
                
        }

        public System.Data.Entity.DbSet<MVCparcial.Models.Product> Products { get; set; }
    }
}