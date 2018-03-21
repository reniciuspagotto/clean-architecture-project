using ArquiteturaPadrao.Domain.Entities;
using ArquiteturaPadrao.Infra.Map;
using Flunt.Notifications;
using Microsoft.EntityFrameworkCore;

namespace ArquiteturaPadrao.Infra.Context
{
    public class DataContext : DbContext
    {
        public DbSet<Customer> Customer { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CustomerMap());
        }
    }
}