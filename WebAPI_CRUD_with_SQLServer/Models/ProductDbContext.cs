using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebAPI_CRUD_with_SQLServer.Models
{
    public class ProductDbContext : DbContext
    {
        
            public ProductDbContext(DbContextOptions<ProductDbContext> options)
                : base(options)
            {
            }

            public DbSet<Product> Products { get; set; }
        }
    
}
