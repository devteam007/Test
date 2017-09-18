using System.Data.Entity;
using BookStore.Domain.Entities;

namespace BookStore.Domain.Concrete
{
    public class EFDbContext : DbContext
   
    {
        public DbSet<Product> Products { get; set; }
    }
}