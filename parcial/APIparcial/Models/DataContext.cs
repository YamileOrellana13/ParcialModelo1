using System.Data.Entity;

namespace APIparcial.Models
{
    public class DataContext:DbContext         //DbContex doy Ctrl .
    {
        public DataContext():base("DefaultConnection")        // doy ctor tab tab y me sale todo
        {
                
        }

        public System.Data.Entity.DbSet<APIparcial.Models.Product> Products { get; set; }
    }
}