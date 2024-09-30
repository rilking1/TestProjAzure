using Microsoft.EntityFrameworkCore;

namespace TestProjAzure.Models
{
    public class DBAzuraContext : DbContext
    {
        public DBAzuraContext(DbContextOptions<DBAzuraContext> options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }

    }

}
