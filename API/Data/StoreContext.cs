using Microsoft.EntityFrameworkCore;
using API.Entities;

namespace API.Data
{
    public class StoreContext : DbContext // DbContext is a class that is using as extending itself. It helps to use refernce falor instead of raw access.
    {
        public StoreContext(DbContextOptions<StoreContext> options) : base(options)
        {
        }

        // this DbSet helps to make connection with entities.
        public DbSet<Product> Products { get; set; }
    }
}