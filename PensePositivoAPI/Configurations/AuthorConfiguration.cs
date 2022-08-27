using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PensePositivoAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PensePositivoAPI.Configurations
{
    public class AuthorConfiguration : IEntityTypeConfiguration<Author>
    {
        public void Configure(EntityTypeBuilder<Author> builder)
        {
            builder.HasKey(a => a.Id);
            builder.Property(a => a.Name).HasColumnType("VARCHAR").IsRequired().HasMaxLength(60);
            builder.Property(a => a.Nacionality).HasColumnType("VARCHAR").IsRequired(false).HasMaxLength(35);
            builder.Property(a => a.BirthDate).IsRequired(false);
        }
    }
}
