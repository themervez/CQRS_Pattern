using CQRS_Pattern.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS_Pattern.DAL.Context
{
    public class ProductContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=CQRS;Trusted_Connection=True");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
