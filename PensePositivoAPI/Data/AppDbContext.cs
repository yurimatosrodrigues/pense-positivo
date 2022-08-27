using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PensePositivoAPI.Configurations;
using PensePositivoAPI.Models;

namespace PensePositivoAPI.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<Text> Texts { get; set; }

        string _connectionString = "";

        public AppDbContext(IConfiguration configuration)
        {
            _connectionString = configuration.GetConnectionString("AzureDB");
        }

        protected override void OnConfiguring(
            DbContextOptionsBuilder optionsBuilder) =>
             optionsBuilder.UseLazyLoadingProxies(false)
            .UseSqlServer(connectionString: _connectionString);
             //.UseMySql(connectionString: _connectionString, ServerVersion.AutoDetect(_connectionString));

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
            modelBuilder.ApplyConfiguration(new CategoryConfiguration());
            modelBuilder.ApplyConfiguration(new AuthorConfiguration());
            modelBuilder.ApplyConfiguration(new TextConfiguration());
            base.OnModelCreating(modelBuilder);
        }
    }
}