using ASP_HomeWork_4_.Entities;
using Microsoft.EntityFrameworkCore;

namespace ASP_HomeWork_4_.Context
{
    public class ProductDbContext : DbContext
    {

        public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options)
        {

        }


        public DbSet<Product> Products { get; set; }

    }
}
