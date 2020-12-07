using Microsoft.EntityFrameworkCore;

namespace APIRest_ASPNET5.Models.Context
{
    public class MySQLContext : DbContext
    {
        public MySQLContext()
        {

        }
        
        public MySQLContext(DbContextOptions<MySQLContext> options) : base(options) { }

        public DbSet<Client> Clients { get; set; }

        public DbSet<Vehicle> Vehicles { get; set; }
        //public object Vehicle { get; internal set; }
    }
}
