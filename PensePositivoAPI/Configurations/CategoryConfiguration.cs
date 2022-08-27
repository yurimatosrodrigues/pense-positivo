using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PensePositivoAPI.Models;

namespace PensePositivoAPI.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(c => c.Id);
            builder.Property(p => p.Title).HasColumnType("VARCHAR").IsRequired().HasMaxLength(55);
            builder.Property(p => p.Description).HasColumnType("VARCHAR").IsRequired(false).HasMaxLength(105);
        }
    }
}
