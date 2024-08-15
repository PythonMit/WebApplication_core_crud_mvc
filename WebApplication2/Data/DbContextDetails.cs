using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class DbContextDetails:DbContext
    {
        public DbContextDetails(DbContextOptions<DbContextDetails> options)
           : base(options)
        {
        }

        public virtual DbSet<Product>Products { get; set; }
    }
}
